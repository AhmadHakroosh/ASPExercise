using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace SearsExam.Tests
{
    [TestClass]
    public class ThreeClassNamesTest
    {
        [UrlToTest("http://localhost:55251/App/ThreeClass")]
        [HostType("ASP.NET")]
        [TestMethod]
        public void TestMethod()
        {
        }
    }
}
