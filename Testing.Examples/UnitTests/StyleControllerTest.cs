using System.Collections.Generic;
using System.Web.Mvc;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Constraints;
using SKUApp.Controllers;
using SKUApp.Models;

namespace Testing.Examples.UnitTests
{
    public class StyleControllerTest
    {
        [Test]
        public void ShouldReturnAViewWithSKUResults()
        {
            var expectedModel = new List<SKU> { new SKU() };
            var moq = new Mock<IRepository<SKU>>();
            moq.Setup(x => x.Find("bsshirt")).Returns(expectedModel);
            var styleController = new StyleController(moq.Object);

            var result = styleController.Find("bsshirt");

            Assert.That(result.Model, Is.EqualTo(expectedModel));
        }
    }
}