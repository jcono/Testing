using Microsoft.AspNetCore.Mvc;
using StockInquiry.Models;
using StockInquiry.Models.Domain;

namespace StockInquiry.Controllers
{
    public class StockController : Controller
    {
        private readonly IRepository<Stock> _repository;

        public StockController(IRepository<Stock> repository)
        {
            _repository = repository;
        }

        public ViewResult Find(string id)
        {
            return View(_repository.Find(id));
        }
    }
}
