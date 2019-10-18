using System;
using System.Collections.Generic;
using System.Text;
using BlogMastery.Models;
using Xunit;

namespace BlogMastery.Tests
{
    public class PostModelTest
    {
        Post posttest;
        private DateTime dateTime;

        public PostModelTest()
        {
            posttest = new Post(1, "title", "body", "reviewer", dateTime, 1);
        }

        [Fact]
        public void PostContructor_Sets_Title()
        {
            var result = posttest.Title;

            Assert.Equal("title", result);
        }

        [Fact]
        public void PostContructor_Sets_Body()
        {
            var result = posttest.Body;

            Assert.Equal("body", result);
        }

        [Fact]
        public void PostContructor_Sets_Reviewer()
        {
            var result = posttest.Reviewer;

            Assert.Equal("reviewer", result);
        }
        
        [Fact]
        public void PostContructor_Sets_GenreId()
        {
            var result = posttest.GenreId;

            Assert.Equal(1, result);
        }
    }
}
