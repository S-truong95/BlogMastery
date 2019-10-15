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

        public IEnumerable<Post> GetAll()
        {
            return db.Posts.ToList();
        }

        public Post GetByID(int id)
        {
            return db.Posts.Single(p => p.Id == id);
        }

        public IEnumerable<Post> GetByProductID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
