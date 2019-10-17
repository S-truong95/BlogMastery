using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Models;
using BlogMastery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlogMastery.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> tagRepo;

        public TagController(IRepository<Tag> tagRepo)
        {
            this.tagRepo = tagRepo;
        }

        public ViewResult Index()
        {
            var model = tagRepo.GetAll();
            return View(model);
        }
    }
}