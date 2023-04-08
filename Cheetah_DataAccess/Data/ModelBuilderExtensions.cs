using Cheetah_DataAccess.Dimentions;
using Cheetah_DataAccess.Links;
using Microsoft.EntityFrameworkCore;
using System.Buffers.Text;
using System.Diagnostics;
using System.Security.AccessControl;
using System.Text;
using static Cheetah_Common.SD;

namespace Cheetah_DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<D_UnitType>().HasData(
                new D_UnitType { Id = 1, PCode = 1, PIndex = 1, PName = "Med", PDisplayName = "دارویی" },
                new D_UnitType { Id = 2, PCode = 2, PIndex = 2, PName = "FMCG", PDisplayName = "مصرفی" },
                new D_UnitType { Id = 3, PCode = 3, PIndex = 3, PName = "General", PDisplayName = "کل" }
                );

            modelBuilder.Entity<D_Area>().HasData(
                new D_Area { Id = 1, PCode = 1, PIndex = 1, PName = "DrugSale", PDisplayName = "فروش دارویی", Area_UnitTypeId = 1 },
                new D_Area { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGSale", PDisplayName = "فروش مصرفی", Area_UnitTypeId = 2 },
                new D_Area { Id = 3, PCode = 3, PIndex = 3, PName = "PurchaseAccounting", PDisplayName = "حسابداری خرید", Area_UnitTypeId = 3 },
                new D_Area { Id = 4, PCode = 4, PIndex = 4, PName = "SaleAccounting", PDisplayName = "حسابداری فروش", Area_UnitTypeId = 3 }
                );

            modelBuilder.Entity<D_Location>().HasData(
                new D_Location { Id = 1, PCode = 1, PIndex = 1, PName = "Tehran", PDisplayName = "تهران" },
                new D_Location { Id = 2, PCode = 2, PIndex = 2, PName = "Fars", PDisplayName = "فارس" },
                new D_Location { Id = 3, PCode = 3, PIndex = 3, PName = "Esfahan", PDisplayName = "اصفهان" }
                );

            modelBuilder.Entity<D_FieldType>().HasData(
                new D_FieldType { Id = 1, PCode = 1, PIndex = 1, PName = "Parameter", PDisplayName = "پارامتریک" },
                new D_FieldType { Id = 2, PCode = 2, PIndex = 2, PName = "Number", PDisplayName = "عددی" },
                new D_FieldType { Id = 3, PCode = 3, PIndex = 3, PName = "Date", PDisplayName = "تاریخ" },
                new D_FieldType { Id = 4, PCode = 4, PIndex = 4, PName = "String", PDisplayName = "حروف" }
                );

            modelBuilder.Entity<D_Operand>().HasData(
               new D_Operand { Id = 1, PCode = 1, PIndex = 1, PName = "=", PDisplayName = "مساوی" },
              new D_Operand { Id = 2, PCode = 2, PIndex = 2, PName = "!=", PDisplayName = "مخالف" },
              new D_Operand { Id = 3, PCode = 3, PIndex = 3, PName = ">", PDisplayName = "بزگتر از" },
              new D_Operand { Id = 4, PCode = 4, PIndex = 4, PName = ">=", PDisplayName = "بزرگتر و مساوی" },
              new D_Operand { Id = 5, PCode = 5, PIndex = 5, PName = "<", PDisplayName = " کوچکتر از" },
              new D_Operand { Id = 6, PCode = 6, PIndex = 6, PName = "<=", PDisplayName = "کوچکتر و مساوی" }
              );
            //new D_ParameterType { Id = 8, PCode = 8, PIndex = 8, PName = "InputVar", PDisplayName = "متغییر ورودی" },
            //  new D_ParameterType { Id = 9, PCode = 9, PIndex = 9, PName = "OutputVar", PDisplayName = "متغییر خروجی" },
            //       new D_ParameterType { Id = 1, PCode = 1, PIndex = 1, PName = "OthersShare", PDisplayName = "سهم دیگران" },
            //  new D_ParameterType { Id = 2, PCode = 2, PIndex = 2, PName = "OursShare", PDisplayName = "سهم شرکت" },
            //  new D_ParameterType { Id = 3, PCode = 3, PIndex = 3, PName = "AreaType", PDisplayName = "نوع واحد مرتبط" },
            //  new D_ParameterType { Id = 4, PCode = 4, PIndex = 4, PName = "Staff", PDisplayName = "ستاد" },
            //  new D_ParameterType { Id = 5, PCode = 5, PIndex = 5, PName = "Refrigerator", PDisplayName = "مخدر/ یخچالی" },
            //  new D_ParameterType { Id = 6, PCode = 6, PIndex = 6, PName = "Price", PDisplayName = "مبلغ" },
            modelBuilder.Entity<D_ParameterType>().HasData(
              new D_ParameterType { Id = 7, PCode = 7, PIndex = 7, PName = "ProcessVar", PDisplayName = "متغیر فرآیندی" },
              new D_ParameterType { Id = 10, PCode = 10, PIndex = 10, PName = "ProcessAction", PDisplayName = "اقدام های فرآیندی" }
              );

            modelBuilder.Entity<D_User>().HasData(
                new D_User { Id = 1, PCode = 1, PIndex = 1, PName = "m.sharifi", PDisplayName = "محمد شریفی" },
                new D_User { Id = 2, PCode = 2, PIndex = 2, PName = "a.sharifi", PDisplayName = "امین شریفی" }
                );

            modelBuilder.Entity<L_UserLocation>().HasData(
                new L_UserLocation { Id = 1, PCode = 1, PIndex = 1, PName = "m.sharifi-Tehran", PDisplayName = "محمد شریفی-تهران", FirstId = 1, SecondId = 1 },
                new L_UserLocation { Id = 2, PCode = 2, PIndex = 2, PName = "a.sharifi-Fars", PDisplayName = "امین شریفی-فارس", FirstId = 2, SecondId = 2 }
                );


            modelBuilder.Entity<D_Role>().HasData(
             new D_Role { Id = 1, PCode = 1, PIndex = 1, PName = "PharmaceuticalDeputy", PDisplayName = "معاونت دارویی" },
             new D_Role { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGDeputy", PDisplayName = "معاونت غذایی" },
             new D_Role { Id = 3, PCode = 3, PIndex = 3, PName = "BusinessSpecialist", PDisplayName = "کارشناس بازرگانی" },
             new D_Role { Id = 4, PCode = 4, PIndex = 4, PName = "SalesSpecialist", PDisplayName = "کارشناس فروش" },
             new D_Role { Id = 5, PCode = 5, PIndex = 5, PName = "DistributionCenterManager", PDisplayName = "مدیریت مرکز توزیع" }
             );

            modelBuilder.Entity<D_Position>().HasData(
         new D_Position { Id = 1, PCode = 1, PIndex = 1, PName = "PharmaceuticalDeputy", PDisplayName = "معاون دارویی", PSO_Independent = true },
         new D_Position { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGDeputy", PDisplayName = "معاون غذایی", PSO_Independent = true },
         new D_Position { Id = 3, PCode = 3, PIndex = 3, PName = "BusinessSeniorSpecialist", PDisplayName = "کارشناس ارشد بازرگانی", PSO_Independent = true },
         new D_Position { Id = 4, PCode = 4, PIndex = 4, PName = "BusinessSpecialist", PDisplayName = "کارشناس بازرگانی", PSO_Independent = true },
         new D_Position { Id = 5, PCode = 5, PIndex = 5, PName = "SalesSeniorSpecialist", PDisplayName = "کارشناس ارشد فروش", PSO_Independent = true },
         new D_Position { Id = 6, PCode = 6, PIndex = 6, PName = "SalesSpecialist", PDisplayName = "کارشناس فروش", PSO_Independent = true },
         new D_Position { Id = 7, PCode = 7, PIndex = 7, PName = "DistributionCenterManager", PDisplayName = "مدیر مرکز توزیع", PSO_Independent = false }
         );


            modelBuilder.Entity<D_Entity>().HasData(
              new D_Entity { Id = 1, PCode = 1, PIndex = 1, PName = "D_Area", PDisplayName = new StringBuilder().Append("واحدها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 2, PCode = 2, PIndex = 2, PName = "D_FieldType", PDisplayName = new StringBuilder().Append("نوع فیلد").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 3, PCode = 3, PIndex = 3, PName = "D_Location", PDisplayName = new StringBuilder().Append("موقعیت ها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 4, PCode = 4, PIndex = 4, PName = "D_Operand", PDisplayName = new StringBuilder().Append("عملگرها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 5, PCode = 5, PIndex = 5, PName = "D_ParameterList", PDisplayName = new StringBuilder().Append("لیست پارامترها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 6, PCode = 6, PIndex = 6, PName = "D_ParameterType", PDisplayName = new StringBuilder().Append("نوع پارامتر").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 7, PCode = 7, PIndex = 7, PName = "D_Position", PDisplayName = new StringBuilder().Append("سمت ها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 8, PCode = 8, PIndex = 8, PName = "D_ProcessEndorsement", PDisplayName = new StringBuilder().Append("تاییدات فرآیندی").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 9, PCode = 9, PIndex = 9, PName = "D_ProcessState", PDisplayName = new StringBuilder().Append("وضعیت فرآیند").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 10, PCode = 10, PIndex = 10, PName = "D_RequestTitle", PDisplayName = new StringBuilder().Append("عنوان درخواست").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 11, PCode = 11, PIndex = 11, PName = "D_Role", PDisplayName = new StringBuilder().Append("نقش ها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 12, PCode = 12, PIndex = 12, PName = "D_Skill", PDisplayName = new StringBuilder().Append("حرفه ها").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 13, PCode = 13, PIndex = 13, PName = "D_SubRequestTitle", PDisplayName = new StringBuilder().Append("زیرعنوان").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 14, PCode = 14, PIndex = 14, PName = "D_UnitType", PDisplayName = new StringBuilder().Append("نوع واحد").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 15, PCode = 15, PIndex = 15, PName = "D_User", PDisplayName = new StringBuilder().Append("کاربران").Append($"({TableType.Dimentions})").ToString() },
              new D_Entity { Id = 16, PCode = 16, PIndex = 16, PName = "F_AllApprove", PDisplayName = new StringBuilder().Append("تاییدها").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 17, PCode = 17, PIndex = 17, PName = "F_Approve", PDisplayName = new StringBuilder().Append("تایید").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 18, PCode = 18, PIndex = 18, PName = "F_Attachment", PDisplayName = new StringBuilder().Append("ضمیمه ها").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 19, PCode = 19, PIndex = 19, PName = "F_EndorsementPosition", PDisplayName = new StringBuilder().Append("لیست سمت ها").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 20, PCode = 20, PIndex = 20, PName = "F_ListOfParameter", PDisplayName = new StringBuilder().Append("لیست پارامترها").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 21, PCode = 21, PIndex = 21, PName = "F_RequestInformation", PDisplayName = new StringBuilder().Append("اطلاعات درخواست ها").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 22, PCode = 22, PIndex = 22, PName = "F_UserInformation", PDisplayName = new StringBuilder().Append("اطلاعات کاربران").Append($"({TableType.Facts})").ToString() },
              new D_Entity { Id = 23, PCode = 23, PIndex = 23, PName = "L_RolePosition", PDisplayName = new StringBuilder().Append("نقش-سمت").Append($"({TableType.Links})").ToString() },
              new D_Entity { Id = 24, PCode = 24, PIndex = 24, PName = "L_UserArea", PDisplayName = new StringBuilder().Append("کاربر-واحدها").Append($"({TableType.Links})").ToString() },
              new D_Entity { Id = 25, PCode = 25, PIndex = 25, PName = "L_UserLocation", PDisplayName = new StringBuilder().Append("کاربر-موقعیت").Append($"({TableType.Links})").ToString() },
              new D_Entity { Id = 26, PCode = 26, PIndex = 26, PName = "L_UserRelatedLocation", PDisplayName = new StringBuilder().Append("کاربر-موقعیت‌های مرتبط").Append($"({TableType.Links})").ToString() },
              new D_Entity { Id = 27, PCode = 27, PIndex = 27, PName = "L_UserPosition", PDisplayName = new StringBuilder().Append("کاربر-سمت").Append($"({TableType.Links})").ToString() },
              new D_Entity { Id = 28, PCode = 28, PIndex = 28, PName = "L_UserSkill", PDisplayName = new StringBuilder().Append("کاربر-حرفه").Append($"({TableType.Links})").ToString() }
              );


        }
    }
}
