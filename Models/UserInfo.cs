using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="İsim alanı zorunlu")]
        public string? Name { get; set; }

        [Required(ErrorMessage ="Telefon alanı zorunlu")]
        public string? Phone { get; set; }
        
        [Required(ErrorMessage ="Email alanı zorunlu")]
        [EmailAddress]
        public string? Email { get; set; }
        [Required(ErrorMessage ="Katılım alanı zorunlu")]
        public bool? WillAttend { get; set; }
    }

}