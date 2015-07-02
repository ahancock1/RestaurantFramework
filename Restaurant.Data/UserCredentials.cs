using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Restaurant.Data.Management.Staff;

namespace Restaurant.Data
{
    public class UserCredential : Entity
    {
        [Key, ForeignKey("User")]
        public int UserCredentialID { get; set; }

        // Hash the fuck out of this
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password salt is required")]
        public string PasswordSalt { get; set; }

//        [Required(ErrorMessage = "Privilege is required")]
        public Privilege Privilege { get; set; }

        public virtual User User { get; set; }


        public UserCredential()
        {
            // Calculate password salt here

        }
    }
}