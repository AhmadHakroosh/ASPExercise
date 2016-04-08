using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Web;

namespace SearsExam.Models
{
    public class ClassName
    {
        public string className { get; private set; }

        public ClassName()
        {
            className = getClassName();
        }

        private string getClassName()
        {
            string url = "http://classnamer.com/index.txt";
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
    }
}