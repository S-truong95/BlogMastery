using System;
using System.Collections.Generic;
using System.Text;
using BlogMastery.Models;
using Xunit;
using BlogMastery.Repository;
using BlogMastery.Controllers;
using NSubstitute;
using Microsoft.AspNetCore.Mvc;

namespace BlogMastery.Tests
{
    public class PostModelTest
    {
        Post posttest;
        PostController underTest;
        private DateTime dateTime;
        IList<PostTag> postTags;
        IRepository<Post> postRepo;
        public PostModelTest()
        {
            posttest = new Post(1, "title", "body", "reviewer", dateTime, 1, postTags);
            postRepo = Substitute.For<IRepository<Post>>();
            underTest = new PostController(postRepo);
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

        [Fact]
        public void Details_Passes_A_Post_To_View()
        {
            var result = underTest.Details(1);
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void Details_Passes_Single_Post()
        {
            var expectedPost = new Post();
            postRepo.GetById(1).Returns(expectedPost);
            var result = underTest.Details(1);
            Assert.Equal(expectedPost, result.Model);
        }
        [Fact]
        public void Index_Returns_A_View()
        {
            var result = underTest.Index();
            Assert.IsType<ViewResult>(result);
        }
        [Fact]
        public void Index_Passes_All_Posts_To_View()
        {
            var expectedPost = new List<Post>();
            postRepo.GetAll().Returns(expectedPost);
            var result = underTest.Index();
            Assert.Equal(expectedPost, result.Model);
        }
    }
}
