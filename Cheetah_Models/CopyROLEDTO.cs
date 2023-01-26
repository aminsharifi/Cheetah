using System.ComponentModel.DataAnnotations;

namespace Cheetah_Models
{
    public class CopyROLEDTO
    {
        public int idRole { get; set; }

        [Required(ErrorMessage = "وارد کردن نام نقش الزامی است.")]
        [StringLength(26)]
        public string roleName { get; set; }
    }
}