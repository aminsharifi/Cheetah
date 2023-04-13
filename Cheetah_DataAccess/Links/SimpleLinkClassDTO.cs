using Cheetah_DataAccess.Data;

namespace Cheetah_DataAccess.Links
{
    public class SimpleLinkClassDTO
    {
        public string linkType { get; set; }
        public string firstType { get; set; }
        public string secondType { get; set; }
        public string sd_Status { get; set; }
        public long fixedId { get; set; }
        public Dictionary<Tuple<long,string>, bool> floatState { get; set; }
    }
}
