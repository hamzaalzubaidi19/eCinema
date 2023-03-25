using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using eCinema.Data.Base;

namespace eCinema.Models
{
    public class Cinema:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name ="Cinema Logo")]
        public string Logo { get; set; }
        [Required]
        [Display(Name = "Cinema Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Cinema Description")]
        public string  Description { get; set; }
        public List<Movie> movies { get; set; }
    }
}
