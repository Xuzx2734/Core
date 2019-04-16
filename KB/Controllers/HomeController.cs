using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using KB.Models;
using Contracts;

namespace KB.Controllers
{
    public class HomeController : Controller
    {
        private ILoggerManager _logger;
        private IRepositoryWrapper _repoWrapper;
        private IUserService _userService;

        public HomeController(
            ILoggerManager logger, 
            IRepositoryWrapper repoWrapper,
            IUserService userService
            )
        {
            _logger = logger;
            _repoWrapper = repoWrapper;
            _userService = userService;
        }
        
        public IActionResult Index()
        {
            var user = _userService.GetUserByAccount("xuzx");

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
