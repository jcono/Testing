using System.Web.Mvc;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Controllers
{
    public class StyleController : Controller
    {
        private readonly IRepository<SKU> _repository;

        public StyleController() : this(new FakeSKURepository())
        {
        }

        public StyleController(IRepository<SKU> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ViewResult Find(string stylecode)
        {
            return View(_repository.Find(stylecode));
        }
    }
}
