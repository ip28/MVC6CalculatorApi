using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorApi.Controllers;
using Xunit;

namespace CalculatorApiTests
{
    // This project can output the Class library as a NuGet Package.
    // To enable this option, right-click on the project and select the Properties menu item. In the Build tab select "Produce outputs on build".
    public class CalculateControllerTests
    {
        [Fact]
        public void TrueTest()
        {
            Assert.True(true);
        }
        [Theory]
        [InlineData(1,2)]
        public void AddTest(int a, int b)
        {
            CalculateController controller = new CalculateController();
            var response = controller.Add(a, b);
            Assert.IsType<int>(response);
            Assert.Equal(a + b, response);
        }
    }
}
