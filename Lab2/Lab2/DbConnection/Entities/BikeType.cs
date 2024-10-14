using System.ComponentModel.DataAnnotations;

namespace Lab2.DbConnection.Entities
{
    public class BikeType
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
