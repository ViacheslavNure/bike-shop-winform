using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace BikeShop.Data.Entities
{
    [Index(nameof(Name), IsUnique = true)]
    public class BikeType
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        public virtual ICollection<Bike> Bikes { get; set; }

        public override bool Equals(object? obj)
        {
            if(obj is BikeType bikeType)
            {
                return bikeType.Name == Name && bikeType.Description == Description;
            }

            return false;
        }
    }
}
