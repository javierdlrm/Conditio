using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Conditio.Models
{
    public class ComparatorViewModel
    {
        [Required(ErrorMessage = "The url is required")]
        public string UrlOne { get; set; }
        
        public List<KeyValuePair<string, int>> Price { get; set; }
        public List<KeyValuePair<string, int>> Delivery { get; set; }
        public List<KeyValuePair<string, int>> Refund { get; set; }
        public List<KeyValuePair<string, int>> Cancelation { get; set; }
        public List<KeyValuePair<string, int>> Guarantee { get; set; }
        public List<KeyValuePair<string, int>> Jurisdiction { get; set; }
        public List<KeyValuePair<string, int>> ApplicableLaw { get; set; }
        public List<KeyValuePair<string, int>> Responsibility { get; set; }
        public List<KeyValuePair<string, int>> CookiesPolicy { get; set; }
        public List<KeyValuePair<string, int>> DataProtection { get; set; }
    }
}
