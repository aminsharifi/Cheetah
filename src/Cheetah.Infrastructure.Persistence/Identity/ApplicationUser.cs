using Cheetah.Domain.Entities.Dimentions;

namespace Cheetah.Infrastructure.Persistence.Identity;
public class ApplicationUser : IdentityUser
{
    [Column(Order = 101)]
    public long? IU_UserId { get; set; }

    [Column(Order = 102)]
    [ForeignKey(nameof(IU_UserId))]
    public virtual D_User IU_User { get; set; }
}