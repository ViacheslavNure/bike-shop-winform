using System.ComponentModel.DataAnnotations;

namespace Lab2.ViewModels
{
    public class BikeTypeViewModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
