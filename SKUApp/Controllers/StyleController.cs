using System.Web.Mvc;
using Models.Domain;
using SKUApp.Models;

namespace SKUApp.Controllers
{
    public class StyleController : Controller
    {
        private readonly IRepository<SKU> _repository;

        public StyleController() : this(new FakeRepository())
        {
        }

        public StyleController(IRepository<SKU> repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public ViewResult Find(string stylecode)
        {
            var model = _repository.Find(stylecode);
            return View(model);
        }
    }
}
