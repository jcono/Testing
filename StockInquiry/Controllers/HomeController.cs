using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using StockInquiry.Models;

namespace StockInquiry.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
    }

    public class SimulatorsController : Controller
    {
        private readonly ISimulatorDecider _simulatorDecider;

        public SimulatorsController(ISimulatorDecider simulatorDecider)
        {
            _simulatorDecider = simulatorDecider;
        }

        public ActionResult Index()
        {
            var simulatorKeys = Enum.GetValues(typeof(SimulatorKey)).Cast<SimulatorKey>();
            var dictionary = simulatorKeys.ToDictionary(key => key, key => _simulatorDecider.ShouldSimulate(key));
            return View(dictionary);
        }

        public ActionResult Change(SimulatorKey simulatorKey, bool value)
        {
            _simulatorDecider.ChangeSimulatorTo(simulatorKey, value);
            return RedirectToAction("Index");
        }
    }
}
