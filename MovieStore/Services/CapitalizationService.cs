using MovieStore.Models;

namespace MovieStore.Services
{
    public interface ICapitalizationService
    {
        MoviesRegistrationResultViewModel Capitalize(MoviesRegistrationViewModel viewModel);
    }

    public class CapitalizationService : ICapitalizationService
    {
        public MoviesRegistrationResultViewModel Capitalize(MoviesRegistrationViewModel viewModel)
        {
            return new MoviesRegistrationResultViewModel
            {
                Title = viewModel.Title.ToUpper(),
                Genre = viewModel.Genre.ToUpper(),
                Year = viewModel.Year.ToUpper(),
                Actor = viewModel.Actor.ToUpper(),
                Director = viewModel.Director.ToUpper(),
                Result = "Accepted"
            };
        }
    }
}