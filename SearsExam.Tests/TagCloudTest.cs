﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.Web;
using SearsExam.Controllers;
using System.Web.Mvc;

namespace SearsExam.Tests
{
    [TestClass]
    public class TagCloudTest
    {
        [TestMethod]
        public void TestMethod()
        {
            AppController ctrl = new AppController();
            ActionResult result = ctrl.TagCloud();
        }
    }
}
