using System.ComponentModel.DataAnnotations;

namespace BikeShop.Application.ViewModels
{
    public class BikeViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(100)]
        public string BrandName { get; set; }

        [Required]
        [StringLength(200)]
        [MinLength(3)]
        public string Model { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [Required]
        [MinLength(0)]
        public string Price { get; set; }

        public Guid BikeTypeId { get; set; }

        public virtual BikeTypeViewModel BikeType { get; set; }

        public override bool Equals(object? obj)
        {
            if (obj is BikeViewModel bike)
            {
                return bike.BrandName == BrandName
                    && bike.Model == Model
                    && bike.Description == Description
                    && bike.Price == Price
                    && bike.BikeType.Equals(BikeType);
            }

            return false;
        }
    }
}
