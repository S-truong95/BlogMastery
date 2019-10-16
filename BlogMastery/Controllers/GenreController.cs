using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Models;
using BlogMastery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlogMastery.Controllers
{
    public class GenreController : Controller
    {
        public GenreController(IRepository<Genre> genreRepo)
        {
            //this.genreRepo = genreRepo;
        }
    }
}
