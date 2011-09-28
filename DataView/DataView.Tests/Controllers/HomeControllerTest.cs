using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Script.Serialization;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DataView;
using DataView.Controllers;

namespace DataView.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreEqual("Exchange Grid Data", result.ViewBag.Message);
        }

        [TestMethod]
        public void ExchangeGrid()
        {
            HomeController controller = new HomeController();
            //var exchange = controller.ExchangeGrid("test", "karl", 1, 3) as JsonResult;
            //var serializer = new JavaScriptSerializer();
            //var output = serializer.Serialize(exchange.Data);

            //Console.WriteLine(output);
        }


        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
