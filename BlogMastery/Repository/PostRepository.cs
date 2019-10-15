using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Models;

namespace BlogMastery.Repository
{
    public class PostRepository : IRepository<Post>
    {
        public IEnumerable<Post> GetAll()
        {
            throw new NotImplementedException();
        }

        public Post GetByID(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetByProductID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
