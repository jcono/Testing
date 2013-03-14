using System.Web.Mvc;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Controllers
{
    public class StockController : Controller
    {
        private readonly IRepository<Stock> _repository;

        public StockController() : this(new FakeStockRepository())
        {
            
        }

        public StockController(IRepository<Stock> repository)
        {
            _repository = repository;
        }

        public ViewResult Find(dynamic id)
        {
            return View(_repository.Find(id));
        }
    }
}
