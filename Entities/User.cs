using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace CovidWebAPI.Entities
{

    [Table("Users")]
    public class User
    {
        [Key] //primary key
        public int Id { get; set; }

        [StringLength(50)]
        [Column(TypeName= "varchar")]
        [Required(ErrorMessage ="Name is required")]
        
        public string Name { get; set; }

        [StringLength (50)]
        [Column(TypeName="varchar")]
        [Required(ErrorMessage = "Email is required")]

        public string Email { get; set; }
        [StringLength(60)]
        [Column(TypeName ="varchar")]
        [Required(ErrorMessage = "Password is required")]

        public string Password { get; set; }

    }
}
