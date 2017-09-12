using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeCinema.Web.Models
{
    public class RootObject
    {
        public List<SearchRepoModel> Search { get; set; }
        public string totalResults { get; set; }
        public string Response { get; set; }
    }
}