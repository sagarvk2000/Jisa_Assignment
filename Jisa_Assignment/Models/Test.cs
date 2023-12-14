using System.ComponentModel.DataAnnotations;

namespace Jisa_Assignment.Models
{
    public class Test
    {
        //Create a web page with a form that collects user information(name, email, and phone number) and
        //displays a confirmation message upon submission
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Email { get; set; }
        [Required]
        public string? PhoneNumber { get; set; }
    }
}
