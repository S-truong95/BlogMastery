using System;
using BlogMastery.Controllers;
using Microsoft.AspNetCore.Mvc;
using Xunit;


namespace BlogMastery.Tests
{
    public class HomeControllerTest
    {
        [Fact]
        public void Index_Returns_View()
        {
            var controller = new HomeController();

            var result = controller.Index();

            Assert.IsType<ViewResult>(result);
        }
    }
}
