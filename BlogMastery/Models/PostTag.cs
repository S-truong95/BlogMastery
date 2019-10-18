using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class PostTag
    {
        public int PostId { get; set; }
        public virtual Post Posts { get; set; }

        public int TagId { get; set; }
        public virtual Tag Tags { get; set; }
    }
}
