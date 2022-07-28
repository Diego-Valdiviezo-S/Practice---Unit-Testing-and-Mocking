using Moq;

namespace TestMock
{
    public class Test
    {
        [Fact]
        public void MockICalculator()
        {
            Mock<ICalculator> calc = new Mock<ICalculator>();
            calc.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns
                ((int first, int second) => first + second);
            calc.Setup(c => c.Sub(It.IsAny<int>(), It.IsAny<int>())).Returns
                ((int first, int second) => first - second);
            calc.Setup(c => c.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns
                ((int first, int second) => first + second);
            calc.Setup(c => c.Div(It.IsAny<int>(), It.IsAny<int>())).Returns
                ((int first, int second) => first / second);        

        }

        [Fact]
        public void MockFibonacci()
        {
            //Arrange
            Mock<ICalculator> calc = new Mock<ICalculator>();
            calc.Setup(c => c.Add(It.IsAny<int>(), It.IsAny<int>())).Returns
                ((int first, int second) => first + second);

            Series series = new Series(calc.Object);

            int number = 3;
            int expected = 2;
            int result;

            //Act
            result = series.Fibonacci(number);

            //Assert
            Assert.Equal(expected, result);
            calc.Verify(c => c.Add(It.IsAny<int>(), It.IsAny<int>()));

        }

        [Fact]
        public void MockFactorial()
        {
            //Arrange
            Mock<ICalculator> calc = new Mock<ICalculator>();
            calc.Setup(c => c.Mul(It.IsAny<int>(), It.IsAny<int>())).Returns
                ((int first, int second) => first * second);

            Series series = new Series(calc.Object);

            int number = 7;
            int expected = 5040;
            int result;

            //Act
            result = series.Factorial(number);

            //Assert
            Assert.Equal(expected, result);
            calc.Verify(c => c.Mul(It.IsAny<int>(), It.IsAny<int>()));

        }

    }
}