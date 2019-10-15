using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class Genre
    {
        public string Name { get; set; }
        public string Post { get; set; }

        public Genre()
        {

        }

        public Genre(string name, string post)
        {
            Name = name;
            Post = post;
        }
    }
}
