using System.ComponentModel.DataAnnotations;

namespace Lab2.DbConnection.Entities
{
    public class Bike
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(200)]
        public string Model { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [MinLength(0)]
        public decimal Price { get; set; }

        public Guid BikeTypeId { get; set; }

        public virtual BikeType BikeType { get; set; }

        public virtual ICollection<Feedback> Feedbacks { get; set; }
    }
}
