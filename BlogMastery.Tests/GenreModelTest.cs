using System;
using System.Collections.Generic;
using System.Text;
using BlogMastery.Models;
using Xunit;

namespace BlogMastery.Tests
{
    public class GenreModelTest
    {
        Genre genreTest;
        private ICollection<Post> posts;

        public GenreModelTest()
        {
            genreTest = new Genre(1, "name", posts);
        }

        [Fact]
        public void GenreConstructor_Sets_Id()
        {
            var result = genreTest.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void GenreConstructor_Sets_Name()
        {
            var result = genreTest.Name;

            Assert.Equal("name", result);
        }
    }
}
