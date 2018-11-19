using ff.words.application.Interfaces;
using ff.words.application.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using takint.resume.pages.Models;
using System.Linq;

namespace takint.resume.pages.Controllers
{
    public class HomeController : BaseController
    {
        private readonly IEntryService _entryService;

        public HomeController(IEntryService entryService)
        {
            _entryService = entryService;
        }

        public async Task<IActionResult> Index()
        {
            HomeViewModel vm = new HomeViewModel();
            List<EntryViewModel> allEntries = (List<EntryViewModel>)await _entryService.GetAllAsync<EntryViewModel>();

            vm.ListEntries = allEntries.OrderBy(e => e.CreatedDate).Skip(0).Take(9);

            return View(vm);
        }

        [Route("About")]
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

        public IActionResult PostList()
        {
            return View();
        }

        public IActionResult Post(int postId)
        {
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
