using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using StockInquiry.Controllers;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Tests.Unit
{
    public class StyleControllerTest
    {
        [Test]
        public void ShouldReturnAViewWithSKUResults()
        {
            const string STYLECODE = "bsshirt";

            var expectedModel = new List<SKU> { new SKU() };
            var moq = new Mock<IRepository<SKU>>();
            moq.Setup(x => x.Find(STYLECODE)).Returns(expectedModel);
            var styleController = new SKUController(moq.Object);

            var result = styleController.Find(STYLECODE);

            Assert.That(result.Model, Is.EqualTo(expectedModel));
        }
    }
}
