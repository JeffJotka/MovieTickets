using MovieTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
    public class Cinema: IEntityBase
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Cinema Logo")]
        public string Logo { get { return $"https://avatars.dicebear.com/api/croodles-neutral/seed-{Id}.svg"; } }

        [Display(Name = "Cinema Name")]
        [Required(ErrorMessage = "Cinema name is required")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Cinema description is required")]
        public string Description { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
