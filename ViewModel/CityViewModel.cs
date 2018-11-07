using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CityApplication.ViewModel
{
    public class CityViewModel
    {
        [Required]
        public string Description { get; set; }
    }
}
