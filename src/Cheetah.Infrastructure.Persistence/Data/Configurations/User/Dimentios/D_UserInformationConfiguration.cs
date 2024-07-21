using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Infrastructure.Persistence.Data.Configurations.User.Dimentios;

public class D_UserInformationConfiguration : IEntityTypeConfiguration<D_UserInformation>
{
    public void Configure(EntityTypeBuilder<D_UserInformation> builder)
    {
        builder.HasComment("Additional user information");

        builder
            .Property(e => e.FirstName)
            .HasColumnOrder(100)
            .HasMaxLength(50);

        builder
          .Property(e => e.LastName)
          .HasColumnOrder(101)
          .HasMaxLength(50);


        builder
          .Property(e => e.NotifByEmail)
          .HasColumnOrder(102);


        builder
          .Property(e => e.NotifByMessenger)
          .HasColumnOrder(103);


        builder
          .Property(e => e.NotifByCell)
          .HasColumnOrder(104);


        builder
          .Property(e => e.ContactEmail)
          .HasColumnOrder(105)
          .HasMaxLength(100);


        builder
          .Property(e => e.ContactMessenger)
          .HasColumnOrder(106)
          .HasMaxLength(100);


        builder
          .Property(e => e.ContactCell)
          .HasColumnOrder(107)
          .HasMaxLength(20);

        builder
          .Property(e => e.UserPicture)
          .HasColumnOrder(108);

        builder
          .Property(e => e.NationalCode)
          .HasColumnOrder(109)
          .HasMaxLength(20);

        builder
          .Property(e => e.Birthdate)
          .HasColumnOrder(110);

        builder
          .Property(e => e.InternalPhone)
          .HasColumnOrder(111)
          .HasMaxLength(50);

        builder
          .Property(e => e.Address)
          .HasColumnOrder(112)
          .HasMaxLength(512);

        builder
          .Property(e => e.RegistrationNumber)
          .HasColumnOrder(113)
          .HasMaxLength(215);
    }
}
