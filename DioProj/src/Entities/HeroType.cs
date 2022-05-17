using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DioProj.src.Entities
{
    public enum HeroType
    {
        Knight, 
        Ninja,
        [Display(Name = "White Wizard")]
        WhiteWizard,
        [Display(Name = "Black Wizard")]
        BlackWizard,
    }
}
