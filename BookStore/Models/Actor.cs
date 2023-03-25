using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Data.Base;


namespace eCinema.Models
{
    public class Actor:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage=" Profile Picture is required")]
        [Display(Name ="Profile Picture Url")]

        public string  ProfilePictureUrl { get; set; }
        [Required(ErrorMessage = "The Full Name is required ")]
        [Display(Name = "Full Name ")]
        [StringLength(50,MinimumLength =3,ErrorMessage ="Full Name must be between 3 and 50 char")]
        public string FullName { get; set; }
        [Required(ErrorMessage = "The Biograohy is required ")]
        [Display(Name = "Biograohy")]
        public string Bio { get; set; }
        public List<Movie_Actor> Movie_Actors { get; set; }
       
    }
}
