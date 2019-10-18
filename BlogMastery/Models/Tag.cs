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

        public virtual IList<PostTag> PostTag { get; set; }

        public Tag()
        {

        }

        public Tag(int id, string name)
        {
            Id = id;
            Name = name;
          
        }
    }
}
