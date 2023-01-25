using System.ComponentModel.DataAnnotations;

namespace Cheetah_Models
{
    public class CopyROLEDTO
    {
        public int idRole { get; set; }

        [Required]
        [StringLength(26)]
        public string roleName { get; set; }
    }
}