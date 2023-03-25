using eCinema.Data.Base;
using eCinema.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace eCinema.Models
{
    public class Movie: IEntityBase
    {
        [Key]
        public int MovieId { get; set; }
        [Required]
        [Display(Name=" Movie Name")]
        public string  Name { get; set; }
        [Required]
        [Display(Name = "Movie Description")]
        public string Description { get; set; }
        
        [Display(Name = "Movie Price")]
        public double Price { get; set; }
        [Required]
        [Display(Name = "Image Url")]
        public string  ImageUrl { get; set; }
        
        [Display(Name = "Star Date")]
        public DateTime starData { get; set; }
        
        [Display(Name = "End Date")]
        public DateTime EndData { get; set; }
        public MoviCategory MoviCategory { get; set; }
        public List<Movie_Actor> Movie_Actors { get; set; }
        public int Id { get; set; }
        [ForeignKey("Id")]
        public Cinema Cinema { get; set; }

         public int ProducerId { get; set; }
        [ForeignKey("ProducerId")]
        public Producer Producer { get; set; }

    }
}
