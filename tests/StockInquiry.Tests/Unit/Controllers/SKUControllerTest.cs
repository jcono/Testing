using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using StockInquiry.Controllers;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Unit.Controllers
{
    public class SKUControllerTest
    {
        [Test]
        public void ShouldReturnAViewWithSKUResults()
        {
            const string STYLE_CODE = "bsshirt";

            var expectedModel = new List<SKU> { new SKU() };
            var moq = new Mock<IRepository<SKU>>();
            moq.Setup(x => x.Find(STYLE_CODE)).Returns(expectedModel);
            var styleController = new SKUController(moq.Object);

            var result = styleController.Find(STYLE_CODE);

            Assert.That(result.Model, Is.EqualTo(expectedModel));
        }
    }
}
