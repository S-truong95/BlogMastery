using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Models;
using BlogMastery.Repository;

namespace BlogMastery.Controllers
{
    public class PostController
    {
        IRepository<Post> postRepo;

        public PostController(IRepository<Post> postRepo)
        {
            this.postRepo = postRepo;

        }

        //public ViewResult PostIndex()
        //{
        //    var model = postRepo.GetAll();
        //    return View(model);
        //}


    }
}
