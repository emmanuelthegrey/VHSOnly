using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VHSOnly.Models;

namespace VHSOnly.ViewModels
{
    public class NewMovieViewModel
    {
        public Movie Movie;
        public IEnumerable<Genre> Genres;
    }
}