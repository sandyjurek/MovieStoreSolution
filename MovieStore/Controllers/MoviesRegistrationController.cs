using Microsoft.AspNetCore.Mvc;
using MovieStore.Models;
using MovieStore.Services;


namespace MovieStore.Controllers
{
    public class MoviesRegistrationController : Controller
    {
        private readonly ICapitalizationService _capitalizationService;
        public MoviesRegistrationController(ICapitalizationService capitalizationService)
        {
            _capitalizationService = capitalizationService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MoviesRegistrationResultView(MoviesRegistrationViewModel moviesRegistrationViewModel)
        {
            var result = _capitalizationService.Capitalize(moviesRegistrationViewModel);
            return View(result);
        }
    }
}

