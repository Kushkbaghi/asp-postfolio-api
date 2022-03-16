﻿using System.ComponentModel.DataAnnotations;

namespace PortfolioAPI.Models
{
    // Handle project info 
    public class Project
    {
        [Key]
        public int Id { get; set; }


        [StringLength(32)]
        [Required(ErrorMessage = "Projektnamn måste vara med!")]
        public string? Name { get; set; }


        [StringLength(250)]
        [Required(ErrorMessage = "Beskrivning måste vara med!")]
        public string? Description { get; set; }

        [StringLength(64)]
        [Required(ErrorMessage = "Projektlänk måste vara med!")]
        public string? Url { get; set; }

        [StringLength(32)]
        public string? ImageName { get; set; }

        [StringLength(64)]
        public string? ImageLink { get; set; }

        [StringLength(64)]
        public string? Tags { get; set; }

        [StringLength(32)]
        public string? CreatedBy { get; set; } = "Okänd";

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}",
               ApplyFormatInEditMode = true)]
        public DateTime? CreateAt { get; set; } = DateTime.Now;
    }
}
