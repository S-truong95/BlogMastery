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


        public Post GetByID(int id)
        {
            return db.Posts.SingleOrDefault(b => b.Id == id);
        }
    }
}
