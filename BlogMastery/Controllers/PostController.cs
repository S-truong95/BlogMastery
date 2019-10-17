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
            var model = postRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = postRepo.GetById(id);

            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            ViewBag.DateTIme = DateTime.Now;
            return View();
        }

        [HttpPost]
        public ActionResult Create(Post posts)
        {
            postRepo.Create(posts);
            return RedirectToAction("PostIndex");
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Post posts)
        {
            postRepo.Delete(posts);
            return RedirectToAction("PostIndex");
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = postRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post posts)
        {
            postRepo.Edit(posts);
            return RedirectToAction("PostIndex");
        }
    }
}
