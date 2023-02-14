using Microsoft.Extensions.Logging;
using PostCodes.WebApi.Service.Controllers;
using PostCodes.WebApi.Service.Data;
using Xunit;

namespace PostCode.WebApi.Test.Service
{
    public class PostCodeControllerTest
    {
        private readonly PostCodeController _controller;
        private readonly ILogger<PostCodeController> _logger;

        public PostCodeControllerTest(ILogger<PostCodeController> logger)
        {
            _logger = logger;
            PostCodeController _controller = new PostCodeController(_logger);
        }


        [Fact]
        public void GetPostCodeTest()
        {

            ;

            //Arrange 
            var postCode = "E13 9BL";
            var result = _controller.GetPostCode(postCode);

            //Vaerifys the Type of the return result 
            var infoType = Assert.IsType<PostCodeInfo>(result);

            Assert.True(infoType.GetType() == typeof(PostCodeInfo));
        }



        [Fact]
        public void GetPostCodesList()
        {

            PostCodeController _controller = new PostCodeController(_logger);

            //Arrange 
            var postCode = "E13";
            var result = _controller.GetPostCodeLists(postCode);

            //Vaerifys the Type of the return result 
            var infoType = Assert.IsType<PostCodesInfo>(result);

            Assert.True(infoType.GetType() == typeof(PostCodesInfo));
        }
    }
}