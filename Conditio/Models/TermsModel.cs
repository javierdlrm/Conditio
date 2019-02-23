using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Conditio.Models
{
    public class TermsModel
    {
        [DisplayName("Key")]
        public string Key { get; set; }

        [DisplayName("Name")]
        public string Name { get; set; }

        [DisplayName("Guarantee")]
        public KeyValuePair<string, int> Guarantee { get; set; }
        
        [DisplayName("Refund")]
        public KeyValuePair<string, int> Refund { get; set; }

        [DisplayName("Delivery")]
        public KeyValuePair<string, int> Delivery { get; set; }

        [DisplayName("Price")]
        public KeyValuePair<string, int> Price { get; set; }

        [DisplayName("Cancelation")]
        public KeyValuePair<string, int> Cancelation { get; set; }

        [DisplayName("Jurisdiction")]
        public KeyValuePair<string, int> Jurisdiction { get; set; }

        [DisplayName("Responsibility")]
        public KeyValuePair<string, int> Responsibility { get; set; }

        [DisplayName("Applicable law")]
        public KeyValuePair<string, int> ApplicableLaw { get; set; }

        [DisplayName("Data protection")]
        public KeyValuePair<string, int> DataProtection { get; set; }

        [DisplayName("Cookies' policy")]
        public KeyValuePair<string, int> CookiesPolicy { get; set; }
    }
}
