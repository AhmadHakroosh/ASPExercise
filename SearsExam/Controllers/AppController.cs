using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Web.Mvc;
using System.IO;
using System.Text.RegularExpressions;
using SearsExam.Models;

namespace SearsExam.Controllers
{
    public class AppController : Controller
    {
        // GET: App
        public ActionResult Index()
        {
            ViewBag.result = new ClassName().className ;
            return View();
        }

        public ActionResult ThreeClass()
        {
            List<ClassName> results = new List<ClassName>();

            for (int i = 0; i < 3; i++)
                results.Add(new ClassName());

            ViewBag.results = results;

            return View();
        }

        public ActionResult TagCloud()
        {
            //variables to be used for my calculation
            Dictionary<string, int> tags = new Dictionary<string, int>();
            List<string> classes = new List<string>();
            ClassName className;
            string[] words;
            //get 200 classes
            for (int i = 0; i < 200; i++)
            {
                className = new ClassName();
                classes.Add(className.className);
                //split the class name by words
                words = Regex.Split(className.className, @"(?<!^)(?=[A-Z])");
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