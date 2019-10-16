using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Models;
using BlogMastery.Repository;
using Microsoft.AspNetCore.Mvc;

namespace BlogMastery.Controllers
{
    public class PostController : Controller
    {
        IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;

        }

        public ViewResult PostIndex()
        {
            //var model = postRepo.GetAll();
            //return View(model);
            return View();
        }


    }
}
