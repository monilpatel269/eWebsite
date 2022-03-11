using System;
using eWebsite.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eWebsite.Models
{
    public class Actor : IEntityBase
    {
        [Key]

        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        [Required(ErrorMessage ="Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name is required")]
        [StringLength(50, MinimumLength =3, ErrorMessage ="Full Name must be between 3 and 50")]
        public string FullName { get; set; }
        [Display(Name = "Biography")]

        [Required(ErrorMessage = "Biography is required")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
