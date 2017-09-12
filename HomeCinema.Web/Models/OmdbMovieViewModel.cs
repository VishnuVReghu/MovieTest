using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCinema.Web.Models
{
    public class OmdbMovieViewModel
    {
        public string Title { get; set; }
        public string Year { get; set; }
        public string imdbID { get; set; }
        public string Type { get; set; }
        public string Poster { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string ReleaseDate { get; set; }
        public string Director { get; set; }
        public string Description { get; set; }

    }
}