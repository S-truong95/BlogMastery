using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Data;
using BlogMastery.Models;

namespace BlogMastery.Repository
{
    public class PostRepository : IRepository<Post>
    {
        private Context db;

        public PostRepository(Context db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Posts.Count();
        }


        public IEnumerable<Post> GetAll()
        {
            return db.Posts;
        }


        public Post GetById(int id)
        {
            return db.Posts.SingleOrDefault(p => p.Id == id);
        }

        public void Create(Post posts)
        {
            db.Posts.Add(posts);
            db.SaveChanges();
        }

        public void Delete(Post posts)
        {
            db.Posts.Remove(posts);
            db.SaveChanges();
        }

        public void Edit(Post posts)
        {
            db.Posts.Update(posts);
            db.SaveChanges();
        }

        public void Save()
        {
            db.SaveChanges();
        }
    }
}
