using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection.Metadata;
using FluentAssertions.Common;
using Cheetah_DataAccess.Parameters;
using Cheetah_DataAccess.Masters;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Cheetah_DataAccess.Dimentions;
using Cheetah_DataAccess.Links;

namespace Cheetah_DataAccess.Data
{
    public partial class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
           
        }
        public virtual DbSet<D_ParameterType> P_ParameterTypes { get; set; }
        public virtual DbSet<D_ParameterList> P_ParameterLists { get; set; }
        public virtual DbSet<D_RequestTitle> P_RequestTitles { get; set; }
        public virtual DbSet<D_ProcessState> P_ProcessStates { get; set; }
        public virtual DbSet<D_SubRequestTitle> P_SubRequestTitles { get; set; }
        public virtual DbSet<D_Position> P_PositionOrgs { get; set; }
        public virtual DbSet<D_ProcessEndorsement> P_ProcessEndorsements { get; set; }
        public virtual DbSet<D_Area> S_Areas { get; set; }
        public virtual DbSet<D_Location> S_Locations { get; set; }
        public virtual DbSet<D_Role> S_Roles { get; set; }
        public virtual DbSet<D_User> S_Users { get; set; }
        public virtual DbSet<D_FieldType> P_FieldTypes { get; set; }
        public virtual DbSet<D_Operand> P_Operands { get; set; }
        public virtual DbSet<F_RequestInformation> M_RequestInformations { get; set; }
        public virtual DbSet<F_Approve> M_Approves { get; set; }
        public virtual DbSet<F_Attachment> M_Attachments { get; set; }
        public virtual DbSet<F_AllApprove> M_AllApproves { get; set; }
        public virtual DbSet<L_RolePosition> L_RolePositions { get; set; }
        public virtual DbSet<L_UserArea> L_UserAreas { get; set; }
        public virtual DbSet<L_UserLocation> L_UserLocations { get; set; }
        public virtual DbSet<L_UserRole> L_UserRoles { get; set; }
        public virtual DbSet<L_UserSkill> L_UserSkills { get; set; }
    }
}