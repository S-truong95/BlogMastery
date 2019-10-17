using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Data;
using BlogMastery.Models;

namespace BlogMastery.Repository
{
    public class TagRepository : IRepository<Tag>
    {
        private Context db;

        public TagRepository(Context db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Tags.Count();
        }

        public void Create(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Tag obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Tag obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Tag> GetAll()
        {
            return db.Tags;
        }

        public Tag GetById(int id)
        {
            return db.Tags.Single(b => b.Id == id);
        }
    }
}
