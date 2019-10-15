using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class Tag
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Post { get; set; }


        public virtual ICollection<Post> Posts { get; set; }

        public Tag()
        {

        }

        public Tag(int id, string name, ICollection<Post> posts)
        {
            Id = id;
            Name = name;
            Posts = posts;
        }
    }
}
