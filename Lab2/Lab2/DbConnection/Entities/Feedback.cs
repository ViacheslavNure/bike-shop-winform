﻿using System.ComponentModel.DataAnnotations;

namespace Lab2.DbConnection.Entities
{
    public class Feedback
    {
        [Required]
        public Guid Id { get; set; }

        [Required]
        [StringLength(500)]
        public string Content { get; set; }

        [Required]
        public DateTime CreationDate { get; set; }

        public Guid BikeId { get; set; }

        public virtual Bike Bike { get; set; }
    }
}
