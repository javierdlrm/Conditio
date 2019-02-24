using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conditio.Models
{
    public class HomeViewModel
    {
        [Required(ErrorMessage ="This fields is required")]
        public string Url { get; set; }
    }
}
