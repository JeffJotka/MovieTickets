using MovieTickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieTickets.Models
{
    public class Producer : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture")]
        public string ProfilePictureURL { get { return $"https://avatars.dicebear.com/api/croodles/moviee-{Id}.svg"; } }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name = "Biography")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }
    }
}