using System.ComponentModel.DataAnnotations;

namespace BikeShop.Application.ViewModels
{
    public class FeedbackViewModel
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        public DateTime CreationDate { get; set; }

        public Guid BikeId { get; set; }
    }
}
