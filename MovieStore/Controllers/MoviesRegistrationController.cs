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
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult MoviesRegistrationResultView(MoviesRegistrationViewModel moviesRegistrationViewModel)
        {
            var result = _capitalizationService.Capitalize(moviesRegistrationViewModel);
            return View(result);
        }
    }
}

