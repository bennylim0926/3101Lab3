namespace ICT3101_Caculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;
        [SetUp]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            // Act
            double result = _calculator.Add(10, 20);
            // Assert
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractTwoNumbers_ResultEqualToSubtract()
        {
            // Act
            double result = _calculator.Subtract(10, 10);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }

        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToMultiply()
        {
            // Act
            double result = _calculator.Multiply(10, 10);
            // Assert
            Assert.That(result, Is.EqualTo(100));
        }

        [Test]
        public void Divide_WhenDivideTwoNumbers_ResultEqualToDivide()
        {
            // Act
            double result = _calculator.Divide(10, 10);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Divide_WithZeroAsSecondInput_ResultEqualPositiveInfinity()
        {
            // Act
            double result = _calculator.Divide(10, 0);
            // Assert
            Assert.That(result, Is.EqualTo(Double.PositiveInfinity));
        }
        
        [Test]
        public void Divide_WithZeroAsFirstInput_ResultEqualZero()
        {
            // Act
            double result = _calculator.Divide(0, 10);
            // Assert
            Assert.That(result, Is.EqualTo(0));
        }
        
        [Test]
        public void Divide_WithZerosAsInputs_ResultEqualOne()
        {
            // Act
            double result = _calculator.Divide(0, 0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Factorial_WhenFactorial_ResultEqualToFactorial()
        {
            // Act
            double result = _calculator.Factorial(5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }

        [Test]
        public void Factorial_WhenFactorial_ResultEqualToFactorial2()
        {
            // Act
            double result = _calculator.Factorial(0);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Factorial_WhenFactorialNegative_ResultThrowArgumentException()
        {
            // Assert
            Assert.That(()=> _calculator.Factorial(-1), Throws.ArgumentException);
        }

        //Triangle
        [Test]
        public void TriangleArea_WhenTriangleArea_ResultEqualToArea()
        {
            double result = _calculator.triangleArea(8, 2);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        [TestCase(0, 2)]
        [TestCase(2, 0)]
        [TestCase(-1,5)]
        [TestCase(5, -3)]
        public void TriangleArea_WhenNegative_ResultThrowArgumentException(double h, double w)
        {
            Assert.That(() => _calculator.triangleArea(h, w), Throws.ArgumentException);
        }

        //Circle
        [Test]
        public void CircleArea_WhenCircleArea_ResultEqualToArea()
        {
            double result = _calculator.circleArea(8);
            Assert.That(result, Is.EqualTo(200.96));
        }

        [Test]
        [TestCase(0)]
        [TestCase(-1)]
        public void CircleArea_WhenNegative_ResultThrowArgumentException(double r)
        {
            Assert.That(() => _calculator.circleArea(r), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }


    }
}