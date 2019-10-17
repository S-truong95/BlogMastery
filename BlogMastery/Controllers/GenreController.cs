using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Repository;
using Microsoft.AspNetCore.Mvc;
using BlogMastery.Models;

namespace BlogMastery.Controllers
{
    public class GenreController : Controller
    {
        IRepository<Genre> genreRepo;

        public GenreController(IRepository<Genre> genreRepo)
        {
            this.genreRepo = genreRepo;
        }

        public ViewResult Index()
        {
            var model = genreRepo.GetAll();
            return View(model);
        }
    }
}