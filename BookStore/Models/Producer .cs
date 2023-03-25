using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
 using eCinema.Data.Base; 

namespace eCinema.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = " Profile Picture is required")]
        [Display(Name ="Profile Picture Url")]
        public string ProfilePictureUrl { get; set; }
        [Required(ErrorMessage = " Full Name is required")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Required(ErrorMessage = " Biograohy is required")]
        [Display(Name = "Biograohy")]
        public string Bio { get; set; }
        public List<Movie> movies { get; set; }
    }
}
