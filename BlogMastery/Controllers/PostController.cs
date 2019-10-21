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
        IRepository<Post> postsRepo;

        public PostController(IRepository<Post> postsRepo)
        {
            this.postsRepo = postsRepo;

        }

        public ViewResult Index()
        {
            var model = postsRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = postsRepo.GetById(id);

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
            postsRepo.Create(posts);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ViewResult Delete(int id)
        {
            var model = postsRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Delete(Post posts)
        {
            postsRepo.Delete(posts);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ViewResult Edit(int id)
        {
            var model = postsRepo.GetById(id);
            return View(model);
        }

        [HttpPost]
        public ActionResult Edit(Post posts)
        {
            postsRepo.Edit(posts);
            return RedirectToAction("Index");
        }
    }
}
