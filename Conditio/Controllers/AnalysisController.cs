using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Conditio.Models;
using Microsoft.AspNetCore.Mvc;

namespace Conditio.Controllers
{
    public class AnalysisController : Controller
    {
        public IActionResult Analysis(string url)
        {
            var model = GetTestViewModel(url);
            return View(model);
        }

        public IActionResult TrackingAlerts()
        {
            return View();
        }

        public IActionResult Comparator()
        {
            return View();
        }
        
        [HttpPost, ValidateAntiForgeryToken]
        public IActionResult Compare(string url_one, string url_two, string url_three)
        {
            ViewData["result"] = true;

            var model = new ComparatorViewModel()
            {
                Price = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Amazon", 1),
                    new KeyValuePair<string, int>("Asos", 1),
                    new KeyValuePair<string, int>("Pccomponentes", 2)
                },
                Delivery = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Amazon", 1),
                    new KeyValuePair<string, int>("Asos", 2)
                },
                Refund = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Asos", 1),
                    new KeyValuePair<string, int>("Amazon", 2),
                    new KeyValuePair<string, int>("Pccomponentes", 2)
                },
                Cancelation = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Amazon", 1),
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Asos", 2)
                },
                Guarantee = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Amazon", 1),
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Asos", 3)
                },
                Jurisdiction = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Amazon", 1),
                    new KeyValuePair<string, int>("Asos", 4)
                },
                ApplicableLaw = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Asos", 1),
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Amazon", 3)
                },
                Responsibility = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Asos", 3),
                    new KeyValuePair<string, int>("Amazon", 3)
                },
                DataProtection = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Asos", 1),
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Amazon", 2)
                },
                CookiesPolicy = new List<KeyValuePair<string, int>>()
                {
                    new KeyValuePair<string, int>("Pccomponentes", 1),
                    new KeyValuePair<string, int>("Asos", 2),
                    new KeyValuePair<string, int>("Amazon", 2)
                }
            };

            return View("Comparator", model);
        }

        private AnalysisViewModel GetTestViewModel(string url)
        {
            string truncated_url = url;
            if (truncated_url.StartsWith("https://"))
            {
                truncated_url = truncated_url.Substring(8);
            }
            if (truncated_url.StartsWith("http://"))
            {
                truncated_url = truncated_url.Substring(7);
            }
            if (truncated_url.StartsWith("www."))
            {
                truncated_url = truncated_url.Substring(4);
            }
            if (truncated_url.Contains("/"))
            {
                truncated_url = truncated_url.Substring(0, truncated_url.IndexOf("/"));
            }

            AnalysisViewModel model = new AnalysisViewModel()
            {
                Url = truncated_url
            };

            return model;
        }

        private IActionResult AnalysisDetails(string key, string subkey, string category)
        {
            var backup = new AnalysisViewModel();
            var terms = backup.TermsDictionary.GetValueOrDefault(key).Find(x => x.Key == subkey);

            var model = new AnalysisDetailsViewModel()
            {
                Category = category,
                Terms = terms
            };

            return View(model);
        }
    }
}