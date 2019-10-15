using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public string Post { get; set; }

        public Tag()
        {

        }

        public Tag(string name, string post)
        {
            Name = name;
            Post = post;
        }
    }
}
