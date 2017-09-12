using HomeCinema.Web.Models;
using System.Collections.Generic;

namespace HomeCinema.Web.Mappings
{
    public static class OmdbMovieMapper
    {
        public static IEnumerable<MovieViewModel> MapPocoToRepoAll(SearchRepoModel modelSource)
        {
            var listMovieRepoData = new List<MovieViewModel>();

            MovieViewModel movieDestData;

            movieDestData = new MovieViewModel();
            movieDestData.Title = modelSource.Title;
            movieDestData.ReleaseDate = modelSource.ReleaseDate;
            movieDestData.Director = modelSource.Director;
            movieDestData.Description = modelSource.Description;
            movieDestData.Image = modelSource.Poster;
                
            listMovieRepoData.Add(movieDestData);

            return listMovieRepoData;
        }
    }
}