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

        [Fact]
        public void HomeController_GuessNumber_InvalidLargeNumber()
        {
            //AAA methodology
            //Arrange
            HomeController controller = new HomeController();
            int number = 120;
            string expectedResult = "Wrong!!! You guessed a large number";

            //Act
            string actualResult = controller.GuessNumber(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }

        [Fact]
        public void HomeController_GuessNumber_InvalidSmallNumber()
        {
            //AAA methodology
            //Arrange
            HomeController controller = new HomeController();
            int number = 80;
            string expectedResult = "Wrong!!! You guessed a small number";

            //Act
            string actualResult = controller.GuessNumber(number);

            //Assert
            Assert.Equal(expectedResult, actualResult);
        }
    }
}
