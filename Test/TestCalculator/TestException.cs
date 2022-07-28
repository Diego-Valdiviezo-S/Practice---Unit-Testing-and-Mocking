using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestCalculators
{
    public class TestException
    {
        [Theory]
        [InlineData(1, 0)]
        public void DivShould_ThrowException_WhenDivideByZero(int number1, int number2)
        {
            //Arrange
            Calculator calculator = new Calculator();

            //Act


            //Assert
            Assert.Throws<DivideByZeroException>(() => calculator.Div(number1, number2));

        }

    }
}
