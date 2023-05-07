using AutoMapper;
using Cheetah_Business;
using Cheetah_Business.Data;
using Cheetah_Business.Facts;
using Cheetah_Business.Repository;
using Cheetah_DataAccess.Data;
using Microsoft.EntityFrameworkCore;
using System.Text;

namespace Cheetah_DataAccess.Repository
{

    public class SimpleClassRepository : ISimpleClassRepository
    {
        protected ApplicationDbContext _db;
        protected IMapper _mapper;

        public SimpleClassRepository(ApplicationDbContext db, IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
        }
        public async Task<Int32> AddLink(SimpleLinkClassDTO obj_DTO)
        {
            await _db.AddAsync(obj_DTO);

            return 1;
        }
        public async Task<SimpleLinkClass> AddLinkName(SimpleLinkClass simpleLinkClass, SimpleClass? firstClass, SimpleClass? SecondClass)
        {
            simpleLinkClass.PDisplayName = new StringBuilder()
                     .Append(firstClass?.PDisplayName ?? String.Empty)
                     .Append("-")
                     .Append(SecondClass?.PDisplayName ?? String.Empty)
                     .ToString();

            simpleLinkClass.PName = new StringBuilder()
                              .Append(firstClass?.PName ?? String.Empty)
                              .Append("-")
                              .Append(SecondClass?.PName ?? String.Empty)
                              .ToString();
            return simpleLinkClass;
        }
        public async Task<F_Request> PerformRequestAsync(F_Request request)
        {
            F_Request GeneralRequest = request;
            try
            {

                #region Create

                if (GeneralRequest.Id is null || GeneralRequest.Id == 0)
                {
                    #region Initials
                    var temp_Request = await GetLast(nameof(F_Request)) as F_Request;
                    GeneralRequest.Id = null;
                    GeneralRequest.PCode = temp_Request.PCode;
                    GeneralRequest.PIndex = temp_Request.PIndex;
                    GeneralRequest.PName = nameof(F_Request) + "-" + temp_Request.PCode;
                    GeneralRequest.PDisplayName = nameof(F_Request) + "-" + temp_Request.PCode;
                    #endregion

                    #region f_AllReview

                    var f_AllReview = await GetLast(nameof(F_AllReview)) as F_AllReview;

                    GeneralRequest.RI_AllReview.Id = null;
                    GeneralRequest.RI_AllReview.PName =
                        GeneralRequest.RI_AllReview.PDisplayName =
                        f_AllReview.PCode.Value.ToString();

                    GeneralRequest.RI_AllReview.PCode = f_AllReview.PCode;
                    GeneralRequest.RI_AllReview.PIndex = f_AllReview.PIndex;

                    #endregion

                }
                else
                {
                    GeneralRequest = await Get(nameof(F_Request), request.Id) as F_Request;
                }

                #endregion

                #region Current_Review

                var f_Review = await GetLast(nameof(F_Review)) as F_Review;

                GeneralRequest.RI_AllReview.AR_Current_Review.Id = f_Review.Id;
                GeneralRequest.RI_AllReview.AR_Current_Review.PCode = f_Review.PCode;
                GeneralRequest.RI_AllReview.AR_Current_Review.PIndex = f_Review.PIndex;
                GeneralRequest.RI_AllReview.AR_Current_Review.PName = GeneralRequest.PName + "-" + f_Review.PCode;
                GeneralRequest.RI_AllReview.AR_Current_Review.PDisplayName = request.RI_AllReview.AR_Current_Review.PDisplayName;
                GeneralRequest.RI_AllReview.AR_Current_Review.APV_TagId = request.RI_AllReview.AR_Current_Review.APV_TagId;
                GeneralRequest.RI_AllReview.AR_Current_Review.APV_UserInChargeId = request.RI_AllReview.AR_Current_Review.APV_UserInChargeId;
                GeneralRequest.RI_AllReview.AR_Current_Review.APV_EndorsementId = request.RI_AllReview.AR_Current_Review.APV_EndorsementId;

                #endregion
                if (GeneralRequest.Id is null || GeneralRequest.Id == 0)
                {
                    var tmp = await _db.AddAsync(GeneralRequest);
                    GeneralRequest = tmp.Entity;
                }
                else
                {
                    var tmp = _db.Update(GeneralRequest);
                    GeneralRequest = tmp.Entity;
                }

                await _db.SaveChangesAsync();
                GeneralRequest.RI_AllReview.AR_Current_Review.APV_AllReviewId = GeneralRequest.RI_AllReview.Id;
                await _db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

            var ret_Requests = await _db.F_Requests.Where(x => x.Id == GeneralRequest.Id)
                .Include(x => x.RI_AllReview.AR_Current_Review.APV_Tag)
                .Include(x => x.RI_AllReview.AR_Current_Review.APV_UserInCharge)
                .Include(x => x.RI_AllReview.AR_Current_Review.APV_Endorsement)
                .FirstAsync();

            return ret_Requests;
        }
        public async Task<SimpleClass> Create(SimpleClass obj_DTO)
        {
            await _db.AddAsync(obj_DTO);
            await _db.SaveChangesAsync();
            return obj_DTO;
        }
        public async Task<Int32> delete(string type, Int64? id)
        {
            if (!String.IsNullOrEmpty(type))
            {
                var gtype = DatabaseClass.GetDBType(type);
                var obj = await _db.FindAsync(gtype, id);

                if (obj != null)
                {
                    _db.Remove(obj);
                    return await _db.SaveChangesAsync();
                }
                return -1;
            }
            return -1;
        }
        public async Task<SimpleClass> Get(string type, Int64? id, QueryTrackingBehavior Tracking = QueryTrackingBehavior.TrackAll)
        {
            if (!String.IsNullOrEmpty(type))
            {
                var gtype = DatabaseClass.GetDBType(type);

                if (!id.HasValue)
                {
                    id = 0;
                }
                if (id == 0)
                {
                    return await GetLast(type);
                }
                else
                {
                    _db.ChangeTracker.QueryTrackingBehavior = Tracking;

                    var _SimpleClass = await _db.FindAsync(gtype, id) as SimpleClass;

                    return _SimpleClass;
                }
            }
            return null;

        }
        public async Task<IEnumerable<SimpleClass>> GetAllByName(string type)
        {
            if (!String.IsNullOrEmpty(type))
            {
                var gtype = DatabaseClass.GetDBType(type);
                var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
                var Result = await Task.FromResult(aa.ToList());
                return Result;
            }
            return new List<SimpleClass>();
        }
        public async Task<IEnumerable<SimpleLinkClass>> GetAllLink(String type, string sd_Status, Int64? linkID)
        {
            if (!String.IsNullOrEmpty(type))
            {
                _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var gtype = DatabaseClass.GetDBType(type);
                var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleLinkClass>;

                var Result = await Task.FromResult(
                    aa.Where(x => (x.FirstId == linkID && sd_Status == nameof(LinkProperty.First)) ||
                    (x.SecondId == linkID && sd_Status == nameof(LinkProperty.Second))).ToList());
                return Result;
            }
            _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            return new List<SimpleLinkClass>();
        }
        public async Task<Dictionary<string, string>> GetAllTableName(string SchemaName)
        {
            if (!String.IsNullOrEmpty(SchemaName))
            {
                _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
                var Result = await Task.FromResult(
                    _db.Model.GetEntityTypes()
                    .ToDictionary(x => x.Name.Split('.').Last(),
                    x => x.Name.Split('.').Last()));
                _db.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
                return Result;
            }
            return new Dictionary<string, string>();
        }
        public async Task<SimpleClass> GetLast(string type)
        {
            var gtype = DatabaseClass.GetDBType(type);
            var aa = DatabaseClass.InvokeSet(_db, gtype) as IEnumerable<SimpleClass>;
            var instance = (SimpleClass)Activator.CreateInstance(gtype);
            instance.PCode = aa.Any() ? aa.Max(x => x.PCode) + 1 : 1;
            instance.PIndex = aa.Any() ? aa.Max(x => x.PIndex) + 1 : 1;
            return instance;
        }
        public async Task<Int32> RemoveLink(SimpleLinkClassDTO obj_DTO)
        {
            _db.Remove(obj_DTO);

            return 1;
        }
        public async Task<SimpleClass> Update(SimpleClass obj_DTO)
        {
            _db.Update(obj_DTO);
            await _db.SaveChangesAsync();
            _db.ChangeTracker.Clear();
            return obj_DTO;
        }
        public async Task<Int32> UpdateLink(SimpleLinkClassDTO obj_DTO)
        {
            var gtype = DatabaseClass.GetDBType(obj_DTO.linkType);

            var allLink = await GetAllLink
                (
                    obj_DTO.linkType,
                    obj_DTO.sd_Status,
                    obj_DTO.fixedId
                );

            _db.RemoveRange(allLink);

            var simpleLinkClass = new List<SimpleLinkClass>();

            var fixedInstance = await Get(
                type: obj_DTO.sd_Status == nameof(LinkProperty.First) ? obj_DTO.firstType : obj_DTO.secondType,
                id: obj_DTO.fixedId, Tracking: QueryTrackingBehavior.NoTracking);

            foreach (var link in obj_DTO.floatState.Where(x => x.Value))
            {
                var instance = (SimpleLinkClass)Activator.CreateInstance(gtype);

                if (simpleLinkClass.Any())
                {
                    instance.PCode = simpleLinkClass.Last().PCode + 1;
                    instance.PIndex = simpleLinkClass.Last().PIndex + 1;
                }
                else
                {
                    instance = await GetLast(obj_DTO.linkType) as SimpleLinkClass;
                }

                Type firstType, secondType;

                firstType = DatabaseClass.GetDBType(obj_DTO.firstType);

                secondType = DatabaseClass.GetDBType(obj_DTO.secondType);


                if (obj_DTO.sd_Status == nameof(LinkProperty.First))
                {
                    instance.FirstId = obj_DTO.fixedId;
                    instance.SecondId = link.Key.Item1;

                }
                else
                {
                    instance.FirstId = link.Key.Item1;
                    instance.SecondId = obj_DTO.fixedId;
                }

                var floatedInstance = await Get(
                type: obj_DTO.sd_Status == nameof(LinkProperty.First) ? obj_DTO.secondType : obj_DTO.firstType,
                id: link.Key.Item1, Tracking: QueryTrackingBehavior.NoTracking);

                if (obj_DTO.sd_Status == nameof(LinkProperty.First))
                {
                    instance = await AddLinkName(instance, fixedInstance, floatedInstance);
                }
                else
                {
                    instance = await AddLinkName(instance, floatedInstance, fixedInstance);
                }

                simpleLinkClass.Add(instance);
            }

            await _db.AddRangeAsync(simpleLinkClass);

            return await _db.SaveChangesAsync();
        }
    }
}