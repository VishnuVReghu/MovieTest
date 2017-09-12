using HomeCinema.Entities;
using HomeCinema.Web.Models;

namespace HomeCinema.Web.Infrastructure.Extensions
{
    public static class EntitiesExtensions
    {
        public static void UpdateMovie(this Movie movie, MovieViewModel movieVm)
        {
            movie.Title = movieVm.Title;
            movie.Description = movieVm.Description;
            movie.UserId = movieVm.User_ID;
            movie.State = movieVm.State;
            movie.CreatedDate = movieVm.CreatedDate;
            movie.ModifiedDate = movieVm.ModifiedDate;
        }
    }
}