using MovieTickets.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTickets.Models
{
    public class Actor : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }

        [NotMapped]
        public string ProfilePictureURL { get { return $"https://avatars.dicebear.com/api/adventurer-neutral/kino-{Id}.svg"; } }
    }
}
