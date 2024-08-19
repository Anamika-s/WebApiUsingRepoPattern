using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data;

namespace WebApiUsingRepoPattern.Models
{
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string EMail { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        [Compare("Password")]
        [NotMapped]
        public string ReTypePassword { get; set; }


    }
}