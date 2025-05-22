using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using xUnitWebApplication.Controllers;

namespace xUnitWebApplication.Tests.Controllers
{
    public class HomeControllerTest
    {
        [Fact]
        public void HomeController_Index_ValidResult()
        {
            //AAA methodology
            //Arrange
            HomeController controller = new HomeController();
            string expectedResult = "I am in Home Controller";

            //Act
            string actualResult = controller.Index();

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
