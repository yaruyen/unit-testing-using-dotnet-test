using System;
using fakeRA2.Controllers;
using Xunit;

namespace fakeRA2.Test
{
    public class RAapiControllerTest
    {

        RAapiController _controller;

        public RAapiControllerTest()
        {
            _controller = new RAapiController();

        }

        [Fact]
        public void Test1()
        {
            //Arrange mean that we need to arrange or set up the necessary parameters for the test.
            //Act means just do the action which might be calling a method, calling a controller.
            var result = _controller.Test1();
            //Assert means just evaluate the result.            
            Assert.Equal("test1", result);
        }
    }
}
