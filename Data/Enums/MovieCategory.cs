using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eWebsite.Data
{
    public enum MovieCategory
    {
        [Display(Name ="Action")]
        Action = 1,
        [Display(Name = "Comedy")]
        Comedy,
        [Display(Name = "Drama")]
        Drama,
        [Display(Name = "Documentory")]
        Documentory,
        [Display(Name = "Horror")]
        Horror,
        [Display(Name = "Cartoon")]
        Cartoon
    }
}
