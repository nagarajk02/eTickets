using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="profile Picture Url")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "full Name")]
        public string FullName { get; set; }

        [Display(Name ="biography")]
        public string Bio { get; set; }
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
