namespace TestCalculators
{
    public class TestCalculatorOperations
    {
        [Fact]
        public void AddShould_AddFloats()
        {
            //Arrange
            Calculator calculator = new Calculator();
            float number1 = 0.9f;
            float number2 = 2.1f;
            float expected = 3f;
            float result;
            

            //Act
            result = calculator.Add(number1, number2);

            //Assert
            Assert.Equal(expected, result);
            
        }

        [Fact]
        public void SubShould_SubstractFloats()
        {
            //Arrange
            Calculator calculator = new Calculator();
            float number1 = 5;
            float number2 = 2;
            float expected = 3;
            float result;


            //Act
            result = calculator.Sub(number1, number2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(5, 2, 10)]
        [InlineData(4, 5, 20)]
        [InlineData(4, 3, 12)]
        [InlineData(1, 3, 3)]
        [InlineData(7, 2, 14)]
        public void MulShould_Multiply(float number1, float number2, float expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            float result;

            //Act
           result = calculator.Mul(number1, number2);

            //Assert
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, 2, 5)]
        [InlineData(100, 5, 20)]
        [InlineData(3, 3, 1)]
        [InlineData(14, 2, 7)]
        [InlineData(70, 10, 7)]
        public void DivShould_Divide(float number1, float number2, float expected)
        {
            //Arrange
            Calculator calculator = new Calculator();
            float result;

            //Act
            result = calculator.Div(number1, number2);

            //Assert
            Assert.Equal(expected, result);
        }

    }
}