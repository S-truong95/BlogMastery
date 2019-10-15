using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class Post
    {
       public string Title { get; set; }
       public string Body { get; set; }
       public string Author { get; set; }
       public int PublishDate { get; set; }
       public string Genre { get; set; }
       public string Tag { get; set; }


        public Post()
        {

        }

        public Post(string title, string body, string author, int publishDate, string genre, string tag)
        {
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
            Genre = genre;
            Tag = tag;
        }
    }

   
   
}
