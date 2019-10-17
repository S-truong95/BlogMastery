using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogMastery.Models
{
    public class Post
    {
       public int Id { get; set; }
       public string Title { get; set; }
       public string Body { get; set; }
       public string Author { get; set; }
       public DateTime DateTime { get; set; }

        public virtual int GenreId { get; set; }
        public virtual Genre Genre { get; set; }
        public virtual int TagId { get; set; }
        public virtual Tag Tag { get; set; }

        public Post()
        {

        }

        public Post(int id, string title, string body, string author, DateTime dateTime, int genreId, int tagId)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            DateTime = dateTime;
            GenreId = genreId;
            TagId = tagId;
        }

    }   
}
