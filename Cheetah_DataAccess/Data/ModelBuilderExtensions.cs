using Cheetah_DataAccess.Dimentions;
using Cheetah_DataAccess.Links;
using Microsoft.EntityFrameworkCore;
using System.Text;
using static Cheetah_Common.SD;

namespace Cheetah_DataAccess.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            #region Dimentions

            modelBuilder.Entity<D_Area>().HasData(
                new D_Area { Id = 1, PCode = 1, PIndex = 1, PName = "DrugSale", PDisplayName = "فروش دارویی" },
                new D_Area { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGSale", PDisplayName = "فروش مصرفی" },
                new D_Area { Id = 3, PCode = 3, PIndex = 3, PName = "PurchaseAccounting", PDisplayName = "حسابداری خرید" },
                new D_Area { Id = 4, PCode = 4, PIndex = 4, PName = "SaleAccounting", PDisplayName = "حسابداری فروش" }
                );

            modelBuilder.Entity<D_RequestTitle>().HasData(
                new D_RequestTitle { Id = 1, PCode = 1, PIndex = 1, PName = "CustomerDefinition", PDisplayName = "تعریف/اصلاح مشتری" },
                new D_RequestTitle { Id = 2, PCode = 2, PIndex = 2, PName = "PolicyCenter", PDisplayName = "مجوزهای موردی" },
                new D_RequestTitle { Id = 3, PCode = 3, PIndex = 3, PName = "CustomerCredit", PDisplayName = "اعتباردهی مالی مشتری" }
                );

            modelBuilder.Entity<D_ProcessState>().HasData(
                new D_ProcessState { Id = 1, PCode = 1, PIndex = 1, PName = "Ongoing", PDisplayName = "در دست بررسی" },
                new D_ProcessState { Id = 2, PCode = 2, PIndex = 2, PName = "Editing", PDisplayName = "منتظر بازنگری" },
                new D_ProcessState { Id = 3, PCode = 3, PIndex = 3, PName = "Completed", PDisplayName = "کامل شده" },
                new D_ProcessState { Id = 4, PCode = 4, PIndex = 4, PName = "Aborted", PDisplayName = "ابطال شده" }
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
                new D_FieldType { Id = 4, PCode = 4, PIndex = 4, PName = "String", PDisplayName = "حروف" },
                new D_FieldType { Id = 5, PCode = 5, PIndex = 5, PName = "Boolean", PDisplayName = "دودویی" }

                );

            modelBuilder.Entity<D_Operand>().HasData(
                new D_Operand { Id = 1, PCode = 1, PIndex = 1, PName = "=", PDisplayName = "مساوی" },
                new D_Operand { Id = 2, PCode = 2, PIndex = 2, PName = "!=", PDisplayName = "مخالف" },
                new D_Operand { Id = 3, PCode = 3, PIndex = 3, PName = ">", PDisplayName = "بزگتر از" },
                new D_Operand { Id = 4, PCode = 4, PIndex = 4, PName = ">=", PDisplayName = "بزرگتر و مساوی" },
                new D_Operand { Id = 5, PCode = 5, PIndex = 5, PName = "<", PDisplayName = " کوچکتر از" },
                new D_Operand { Id = 6, PCode = 6, PIndex = 6, PName = "<=", PDisplayName = "کوچکتر و مساوی" }
                );

            modelBuilder.Entity<D_ParameterType>().HasData(
                new D_ParameterType { Id = 1, PCode = 1, PIndex = 1, PName = "ProcessVar", PDisplayName = "متغیر فرآیندی" },
                new D_ParameterType { Id = 2, PCode = 2, PIndex = 2, PName = "ProcessAction", PDisplayName = "اقدام‌های فرآیندی" },
                new D_ParameterType { Id = 3, PCode = 3, PIndex = 3, PName = "UnitType", PDisplayName = "نوع واحد" }
                );

            modelBuilder.Entity<D_ParameterList>().HasData(
                new D_ParameterList { Id = 100, PCode = 100, PIndex = 100, PName = "OursShare", PDisplayName = "سهم شرکت", PL_ParameterTypeId = 1 },
                new D_ParameterList { Id = 101, PCode = 101, PIndex = 101, PName = "OthersShare", PDisplayName = "سهم دیگران", PL_ParameterTypeId = 1 },
                new D_ParameterList { Id = 102, PCode = 102, PIndex = 102, PName = "Refrigerator", PDisplayName = "مخدر/ یخچالی", PL_ParameterTypeId = 1 },
                new D_ParameterList { Id = 103, PCode = 103, PIndex = 103, PName = "Price", PDisplayName = "مبلغ", PL_ParameterTypeId = 1 },

                new D_ParameterList { Id = 200, PCode = 200, PIndex = 200, PName = "Approve", PDisplayName = "تایید", PL_ParameterTypeId = 2 },
                new D_ParameterList { Id = 201, PCode = 201, PIndex = 201, PName = "Reject", PDisplayName = "عدم تایید", PL_ParameterTypeId = 2 },
                new D_ParameterList { Id = 202, PCode = 202, PIndex = 202, PName = "Revise", PDisplayName = "بازنگری", PL_ParameterTypeId = 2 },

                new D_ParameterList { Id = 301, PCode = 301, PIndex = 301, PName = "Med", PDisplayName = "دارویی", PL_ParameterTypeId = 3 },
                new D_ParameterList { Id = 302, PCode = 302, PIndex = 302, PName = "FMCG", PDisplayName = "مصرفی", PL_ParameterTypeId = 3 },
                new D_ParameterList { Id = 303, PCode = 303, PIndex = 303, PName = "General", PDisplayName = "کل", PL_ParameterTypeId = 3 }
                );

            modelBuilder.Entity<D_User>().HasData(
                new D_User { Id = 1, PCode = 1, PIndex = 1, PName = "m.sharifi", PDisplayName = "محمد شریفی" },
                new D_User { Id = 2, PCode = 2, PIndex = 2, PName = "a.sharifi", PDisplayName = "امین شریفی" }
                );

            modelBuilder.Entity<D_Role>().HasData(
                new D_Role { Id = 1, PCode = 1, PIndex = 1, PName = "PharmaceuticalDeputy", PDisplayName = "معاونت دارویی", ROL_Independent = true },
                new D_Role { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGDeputy", PDisplayName = "معاونت غذایی", ROL_Independent = true },
                new D_Role { Id = 3, PCode = 3, PIndex = 3, PName = "BusinessSpecialist", PDisplayName = "کارشناس بازرگانی", ROL_Independent = true },
                new D_Role { Id = 4, PCode = 4, PIndex = 4, PName = "SalesSpecialist", PDisplayName = "کارشناس فروش", ROL_Independent = true },
                new D_Role { Id = 5, PCode = 5, PIndex = 5, PName = "DistributionCenterManager", PDisplayName = "مدیریت مرکز توزیع", ROL_Independent = false }
                );

            modelBuilder.Entity<D_Position>().HasData(
                new D_Position { Id = 1, PCode = 1, PIndex = 1, PName = "PharmaceuticalDeputy", PDisplayName = "معاون دارویی" },
                new D_Position { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGDeputy", PDisplayName = "معاون غذایی" },
                new D_Position { Id = 3, PCode = 3, PIndex = 3, PName = "BusinessSeniorSpecialist", PDisplayName = "کارشناس ارشد بازرگانی" },
                new D_Position { Id = 4, PCode = 4, PIndex = 4, PName = "BusinessSpecialist", PDisplayName = "کارشناس بازرگانی" },
                new D_Position { Id = 5, PCode = 5, PIndex = 5, PName = "SalesSeniorSpecialist", PDisplayName = "کارشناس ارشد فروش" },
                new D_Position { Id = 6, PCode = 6, PIndex = 6, PName = "SalesSpecialist", PDisplayName = "کارشناس فروش" },
                new D_Position { Id = 7, PCode = 7, PIndex = 7, PName = "DistributionCenterManager", PDisplayName = "مدیر مرکز توزیع" }
                );


            modelBuilder.Entity<D_Entity>().HasData(
                new D_Entity { Id = 100, PCode = 100, PIndex = 100, PName = "D_Area", PDisplayName = new StringBuilder().Append("واحدها").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 101, PCode = 101, PIndex = 101, PName = "D_FieldType", PDisplayName = new StringBuilder().Append("نوع فیلد").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 102, PCode = 102, PIndex = 102, PName = "D_Location", PDisplayName = new StringBuilder().Append("موقعیت ها").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 103, PCode = 103, PIndex = 103, PName = "D_Operand", PDisplayName = new StringBuilder().Append("عملگرها").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 104, PCode = 104, PIndex = 104, PName = "D_ParameterList", PDisplayName = new StringBuilder().Append("لیست پارامترها").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 105, PCode = 105, PIndex = 105, PName = "D_ParameterType", PDisplayName = new StringBuilder().Append("نوع پارامتر").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 106, PCode = 106, PIndex = 106, PName = "D_Position", PDisplayName = new StringBuilder().Append("سمت ها").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 107, PCode = 107, PIndex = 107, PName = "D_ProcessEndorsement", PDisplayName = new StringBuilder().Append("تاییدات فرآیندی").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 108, PCode = 108, PIndex = 108, PName = "D_ProcessState", PDisplayName = new StringBuilder().Append("وضعیت فرآیند").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 109, PCode = 109, PIndex = 109, PName = "D_RequestTitle", PDisplayName = new StringBuilder().Append("عنوان درخواست").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 110, PCode = 110, PIndex = 110, PName = "D_Role", PDisplayName = new StringBuilder().Append("نقش ها").Append($"({TableType.Dimentions})").ToString() },
                new D_Entity { Id = 113, PCode = 113, PIndex = 111, PName = "D_User", PDisplayName = new StringBuilder().Append("کاربران").Append($"({TableType.Dimentions})").ToString() },

                new D_Entity { Id = 200, PCode = 200, PIndex = 200, PName = "F_AllApprove", PDisplayName = new StringBuilder().Append("تاییدها").Append($"({TableType.Facts})").ToString() },
                new D_Entity { Id = 201, PCode = 201, PIndex = 201, PName = "F_Approve", PDisplayName = new StringBuilder().Append("تایید").Append($"({TableType.Facts})").ToString() },
                new D_Entity { Id = 202, PCode = 202, PIndex = 202, PName = "F_Attachment", PDisplayName = new StringBuilder().Append("ضمیمه ها").Append($"({TableType.Facts})").ToString() },
                new D_Entity { Id = 203, PCode = 203, PIndex = 203, PName = "F_Endorsement", PDisplayName = new StringBuilder().Append("اختصاص نقش‌ها").Append($"({TableType.Facts})").ToString() },
                new D_Entity { Id = 204, PCode = 204, PIndex = 204, PName = "F_ListOfParameter", PDisplayName = new StringBuilder().Append("لیست پارامترها").Append($"({TableType.Facts})").ToString() },
                new D_Entity { Id = 205, PCode = 205, PIndex = 205, PName = "F_RequestInformation", PDisplayName = new StringBuilder().Append("اطلاعات درخواست ها").Append($"({TableType.Facts})").ToString() },
                new D_Entity { Id = 206, PCode = 206, PIndex = 206, PName = "F_UserInformation", PDisplayName = new StringBuilder().Append("اطلاعات کاربران").Append($"({TableType.Facts})").ToString() },


                new D_Entity { Id = 300, PCode = 300, PIndex = 300, PName = "L_RolePosition", PDisplayName = new StringBuilder().Append("نقش-سمت").Append($"({TableType.Links})").ToString() },
                new D_Entity { Id = 301, PCode = 301, PIndex = 301, PName = "L_UserArea", PDisplayName = new StringBuilder().Append("کاربر-واحدها").Append($"({TableType.Links})").ToString() },
                new D_Entity { Id = 302, PCode = 302, PIndex = 302, PName = "L_UserLocation", PDisplayName = new StringBuilder().Append("کاربر-موقعیت").Append($"({TableType.Links})").ToString() },
                new D_Entity { Id = 303, PCode = 303, PIndex = 303, PName = "L_UserRelatedLocation", PDisplayName = new StringBuilder().Append("کاربر-موقعیت‌های مرتبط").Append($"({TableType.Links})").ToString() },
                new D_Entity { Id = 304, PCode = 304, PIndex = 304, PName = "L_UserPosition", PDisplayName = new StringBuilder().Append("کاربر-سمت").Append($"({TableType.Links})").ToString() }
                );

            #endregion

            #region Links
            modelBuilder.Entity<L_UserLocation>().HasData(
                new L_UserLocation { Id = 1, PCode = 1, PIndex = 1, PName = "m.sharifi-Tehran", PDisplayName = "محمد شریفی-تهران", FirstId = 1, SecondId = 1 },
                new L_UserLocation { Id = 2, PCode = 2, PIndex = 2, PName = "a.sharifi-Fars", PDisplayName = "امین شریفی-فارس", FirstId = 2, SecondId = 2 }
               );

            modelBuilder.Entity<L_RolePosition>().HasData(
                new L_RolePosition { Id = 1, PCode = 1, PIndex = 1, PName = "PharmaceuticalDeputy-PharmaceuticalDeputy", PDisplayName = "معاونت دارویی-معاون دارویی", FirstId = 1, SecondId = 1 },
                new L_RolePosition { Id = 2, PCode = 2, PIndex = 2, PName = "FMCGDeputy-FMCGDeputy", PDisplayName = "معاونت غذایی-معاون غذایی", FirstId = 2, SecondId = 2 },
                new L_RolePosition { Id = 3, PCode = 3, PIndex = 3, PName = "BusinessSpecialist-BusinessSeniorSpecialist", PDisplayName = "کارشناس بازرگانی-کارشناس ارشد بازرگانی", FirstId = 3, SecondId = 3 },
                new L_RolePosition { Id = 4, PCode = 4, PIndex = 4, PName = "BusinessSpecialist-BusinessSpecialist", PDisplayName = "کارشناس بازرگانی-کارشناس بازرگانی", FirstId = 3, SecondId = 4 },
                new L_RolePosition { Id = 5, PCode = 5, PIndex = 5, PName = "SalesSpecialist-SalesSeniorSpecialist", PDisplayName = "کارشناس فروش-کارشناس ارشد فروش", FirstId = 4, SecondId = 5 },
                new L_RolePosition { Id = 6, PCode = 6, PIndex = 6, PName = "SalesSpecialist-SalesSpecialist", PDisplayName = "کارشناس فروش-کارشناس فروش", FirstId = 4, SecondId = 6 },
                new L_RolePosition { Id = 7, PCode = 7, PIndex = 7, PName = "DistributionCenterManager-DistributionCenterManager", PDisplayName = "مدیریت مرکز توزیع-مدیر مرکز توزیع", FirstId = 5, SecondId = 7 }
                );
            modelBuilder.Entity<L_UserArea>().HasData(
                new L_UserArea { Id = 1, PCode = 1, PIndex = 1, PName = "a.sharifi-DrugSale", PDisplayName = "امین شریفی-فروش دارویی", FirstId = 2, SecondId = 1 },
                new L_UserArea { Id = 2, PCode = 2, PIndex = 2, PName = "a.sharifi-FMCGSale", PDisplayName = "امین شریفی-فروش مصرفی", FirstId = 2, SecondId = 2 },
                new L_UserArea { Id = 3, PCode = 3, PIndex = 3, PName = "m.sharifi-DrugSale", PDisplayName = "محمد شریفی-فروش دارویی", FirstId = 1, SecondId = 1 },
                new L_UserArea { Id = 4, PCode = 4, PIndex = 4, PName = "m.sharifi-FMCGSale", PDisplayName = "محمد شریفی-فروش مصرفی", FirstId = 1, SecondId = 2 }
                );

            #endregion
        }
    }
}
