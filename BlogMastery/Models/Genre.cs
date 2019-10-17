using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class Genre
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Post> Posts { get; set; }

        public Genre()
        {

        }

        public Genre(int id, string name, ICollection<Post> posts)
        {
            Id = id;
            Name = name;
            Posts = posts;
        }

    }
}
