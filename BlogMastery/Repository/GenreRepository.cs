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
        public IEnumerable<Genre> GetAll()
        {
            return db.Genres.ToList();
        }

        public Genre GetByID(int id)
        {
            return db.Genres.Single(p => p.Id == id); ;
        }

        public IEnumerable<Genre> GetByProductID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
