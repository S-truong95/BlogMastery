using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogMastery.Data;
using BlogMastery.Models;

namespace BlogMastery.Repository
{
    public class GenreRepository : IRepository<Genre>
    {
        private Context db;

        public GenreRepository(Context db)
        {
            this.db = db;
        }

        public int Count()
        {
            return db.Genres.Count();
        }

        public void Create(Genre obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(Genre obj)
        {
            throw new NotImplementedException();
        }

        public void Edit(Genre obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genre> GetAll()
        {
            return db.Genres;
        }

        public Genre GetById(int id)
        {
            return db.Genres.Single(b => b.Id == id);
        }
    }
}
