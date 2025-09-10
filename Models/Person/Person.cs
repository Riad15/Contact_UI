using System.ComponentModel.DataAnnotations;

namespace Contact_UI.Models
{
    public class Person
    {
        public int Id { get; set; }

		[Required(ErrorMessage = "Name is required")]
		public string Name { get; set; } = string.Empty;

		[Required(ErrorMessage = "email is required")]
		[EmailAddress(ErrorMessage = "Invalid email address")]
		public string Email { get; set; } = string.Empty;

		[Required(ErrorMessage = "Phone number is required")]
		public string PhoneNumber { get; set; } = string.Empty;
	
		[StringLength(200, ErrorMessage = "Message cannot be longer than 200 characters.")]
		[Required(ErrorMessage = "Message is required")]
		public string Message { get; set; } = string.Empty;
    }
}
