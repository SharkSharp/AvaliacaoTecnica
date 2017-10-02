using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DB1.AvaliacaoTecnica.API.RH;
using DB1.AvaliacaoTecnica.API.RH.Controllers;

namespace DB1.AvaliacaoTecnica.API.RH.Tests.Controllers
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
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
