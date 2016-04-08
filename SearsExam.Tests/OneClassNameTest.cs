using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;

namespace SearsExam.Tests
{
    [TestClass]
    public class OneClassNameTest
    {
        [UrlToTest("http://localhost:55251/App/Index")]
        [HostType("ASP.NET")]
        [TestMethod]
        public void TestMethod()
        {
        }
    }
}
