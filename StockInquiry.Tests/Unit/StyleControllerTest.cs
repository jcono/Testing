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
            var expectedModel = new List<SKU> { new SKU() };
            var moq = new Mock<IRepository<SKU>>();
            moq.Setup(x => x.Find("bsshirt")).Returns(expectedModel);
            var styleController = new StyleController(moq.Object);

            var result = styleController.Find("bsshirt");

            Assert.That(result.Model, Is.EqualTo(expectedModel));
        }
    }
}
