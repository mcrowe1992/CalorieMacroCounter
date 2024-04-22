using Calorie_Macro_Counter.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Calorie_Macro_Counter.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger)
		{
			_logger = logger;
		}

		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

        public IActionResult Overview()
        {
            return View();
        }

        public IActionResult Routines()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}

        public IActionResult BenchPress()
        {
            return View();
        }

        public IActionResult InclineDumbbellPress()
        {
            return View();
        }

        public IActionResult BarDips()
        {
            return View();
        }

        public IActionResult StandingCableChestFly()
        {
            return View();
        }

        public IActionResult OverheadPress()
        {
            return View();
        }

        public IActionResult SeatedDumbbellShoulderPress()
        {
            return View();
        }

        public IActionResult DumbbellLateralRaise()
        {
            return View();
        }

        public IActionResult ReverseDumbbellFly()
        {
            return View();
        }

        public IActionResult Deadlift()
        {
            return View();
        }

        public IActionResult LatPulldown()
        {
            return View();
        }

        public IActionResult PullUp()
        {
            return View();
        }

        public IActionResult BarbellRow()
        {
            return View();
        }

        public IActionResult DumbbellRow()
        {
            return View();
        }

        public IActionResult BarbellCurl()
        {
            return View();
        }

        public IActionResult DumbbellCurl()
        {
            return View();
        }

        public IActionResult HammerCurl()
        {
            return View();
        }

        public IActionResult OverheadCableTricepsExtension()
        {
            return View();
        }

        public IActionResult TricepPushdown()
        {
            return View();
        }

        public IActionResult Squat()
        {
            return View();
        }

        public IActionResult LegExtension()
        {
            return View();
        }

        public IActionResult LegPress()
        {
            return View();
        }
    }
}
