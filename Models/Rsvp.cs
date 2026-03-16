using System.ComponentModel.DataAnnotations;

namespace Lab3.Models
{
    public class Rsvp
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        [Display(Name = "Workshop Title")]
        public string WorkshopTitle { get; set; }

        [Display(Name = "Do you need special accommodations?")]
        public bool NeedsAccommodation { get; set; }
    }
}