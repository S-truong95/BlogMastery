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
       public string Reviewer { get; set; }
       public DateTime DateTime { get; set; }

        public virtual int GenreId { get; set; }
        public virtual Genre Genre { get; set; }

        public virtual IList<PostTag> PostTag { get; set; }

        public Post()
        {

        }

        public Post(int id, string title, string body, string reviewer, DateTime dateTime, int genreId, IList<PostTag> postTags)
        {
            Id = id;
            Title = title;
            Body = body;
            Reviewer = reviewer;
            DateTime = dateTime;
            GenreId = genreId;
            PostTag = postTags;
        }

    }   
}
