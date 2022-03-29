using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Notepad.Models
{
    public class User
    {
        public int Id { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Name { get; set; }

        [RegularExpression(@"^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$")]
        [Required]
        public string Email { get; set; }
      
        [Display(Name = "Hashed password")]
        [Required]
        public string HashedPassword { get; set; }
        public List<Note> Note { get; set; }


    }
}
