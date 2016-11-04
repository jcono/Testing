using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using StockInquiry.Models;

namespace StockInquiry.Controllers
{
    public class SimulatorsController : Controller
    {
        private readonly ISimulatorDecider _simulatorDecider;

        public SimulatorsController(ISimulatorDecider simulatorDecider)
        {
            _simulatorDecider = simulatorDecider;
        }

        public IActionResult Index()
        {
            var dictionary = new Dictionary<SimulatorKey, bool>();
            var simulatorKeys = Enum.GetValues(typeof(SimulatorKey)).Cast<SimulatorKey>();
            foreach (var key in simulatorKeys)
            {
                dictionary.Add(key, _simulatorDecider.ShouldSimulate(key));
            }
            return View(dictionary);
        }

        public IActionResult Change(SimulatorKey simulatorKey, bool value)
        {
            _simulatorDecider.ChangeSimulatorTo(simulatorKey, value);
            return RedirectToAction("Index");
        }
    }
}
