using FluentValidation;
using HomeCinema.Web.Models;

namespace HomeCinema.Web.Infrastructure.Validators
{
    public class MovieViewModelValidator : AbstractValidator<MovieViewModel>
    {
        public MovieViewModelValidator()
        {
            RuleFor(movie => movie.Title).NotEmpty().Length(1, 50)
              .WithMessage("Select a Title");

            RuleFor(movie => movie.State).NotEmpty()
              .WithMessage("Select a State");

            RuleFor(movie => movie.Description).NotEmpty().Length(0, 100)
                .WithMessage("Select a description");
        
        }
    }
}