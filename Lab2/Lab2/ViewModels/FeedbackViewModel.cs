using Lab2.DbConnection.Entities;
using System.ComponentModel.DataAnnotations;

namespace Lab2.ViewModels
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
