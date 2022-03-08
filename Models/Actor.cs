﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eWebsite.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "Profile Picture URL")]
        public string ProfilePictureURL { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Bio")]
        public string Bio { get; set; }

        //Relationships
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
