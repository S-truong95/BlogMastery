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
       public int PublishDate { get; set; }

        public virtual int GenreId { get; set; }
        public virtual Genre Genres { get; set; }
        public virtual int TagId { get; set; }
        public virtual Tag Tags { get; set; }

        public Post()
        {

        }

        public Post(int id, string title, string body, string author, int publishDate, int genreId, int tagId)
        {
            Id = id;
            Title = title;
            Body = body;
            Author = author;
            PublishDate = publishDate;
            GenreId = genreId;
            TagId = tagId;
        }

    }   
}
