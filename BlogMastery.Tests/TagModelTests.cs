using System;
using System.Collections.Generic;
using System.Text;
using BlogMastery.Models;
using Xunit;

namespace BlogMastery.Tests
{
    public class TagModelTests
    {
        Tag tagTest;
        private ICollection<Post> posts;

        public TagModelTests()
        {
            tagTest = new Tag(1, "name");
        }

        [Fact]
        public void TagConstructor_Sets_Id()
        {
            var result = tagTest.Id;

            Assert.Equal(1, result);
        }

        [Fact]
        public void TagConstructor_Sets_Name()
        {
            var result = tagTest.Name;

            Assert.Equal("name", result);
        }
    }
}
