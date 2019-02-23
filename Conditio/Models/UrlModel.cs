using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conditio.Models
{
    public class UrlModel
    {
        [Required]
        public string Url { get; set; }
    }
}
