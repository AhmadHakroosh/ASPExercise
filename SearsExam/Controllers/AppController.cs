using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.IO;
using System.Text.RegularExpressions;

namespace SearsExam.Controllers
{
    public class AppController : Controller
    {
        private string GetContent(string url)
        {
            string result;

            HttpWebRequest webrequest = (HttpWebRequest)HttpWebRequest.Create(url);
            webrequest.Method = "GET";
            webrequest.ContentLength = 0;

            WebResponse response = webrequest.GetResponse();

            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                result = stream.ReadToEnd();
            }

            result = Regex.Replace(result, @"\r\n?|\n", "");

            return result;
        }

        // GET: App
        public ActionResult Index()
        {
            ViewBag.result = GetContent("http://classnamer.com/index.txt");
            return View();
        }

        public ActionResult ThreeClass()
        {
            List<string> results = new List<string>();

            for (int i = 0; i < 3; i++)
                results.Add(GetContent("http://classnamer.com/index.txt"));

            ViewBag.results = results;

            return View();
        }

        public ActionResult TagCloud()
        {
            //variables to be used for my calculation
            Dictionary<string, int> tags = new Dictionary<string, int>();
            string className;
            List<string> classes = new List<string>();
            string[] words;
            //get 200 classes
            for (int i = 0; i < 200; i++)
            {
                className = GetContent("http://classnamer.com/index.txt");
                classes.Add(className);
                //split the class name by words
                words = Regex.Split(className, @"(?<!^)(?=[A-Z])");
                foreach (var word in words)
                {
                    if (tags.ContainsKey(word))
                        tags[word]++;
                    else
                        tags.Add(word, 1);
                }
            }

            ViewBag.tags = tags;
            ViewBag.classes = classes;

            return View();
        }
    }
}