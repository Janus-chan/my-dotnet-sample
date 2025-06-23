using SampleApp;

namespace SampleApp.Tests;

public class CalculatorTests
{
    private readonly Calculator _calculator;

    public CalculatorTests()
    {
        _calculator = new Calculator();
    }

    #region Basic Operations Tests
    [Fact]
    public void Add_TwoPositiveNumbers_ReturnsCorrectSum()
    {
        // Arrange
        int a = 5;
        int b = 3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(8, result);
    }

    [Fact]
    public void Add_PositiveAndNegativeNumber_ReturnsCorrectSum()
    {
        // Arrange
        int a = 10;
        int b = -3;

        // Act
        int result = _calculator.Add(a, b);

        // Assert
        Assert.Equal(7, result);
    }

    [Fact]
    public void Subtract_TwoNumbers_ReturnsCorrectDifference()
    {
        // Arrange
        int a = 10;
        int b = 4;

        // Act
        int result = _calculator.Subtract(a, b);

        // Assert
        Assert.Equal(6, result);
    }

    [Fact]
    public void Multiply_TwoNumbers_ReturnsCorrectProduct()
    {
        // Arrange
        int a = 6;
        int b = 7;

        // Act
        int result = _calculator.Multiply(a, b);

        // Assert
        Assert.Equal(42, result);
    }

    [Fact]
    public void Divide_TwoNumbers_ReturnsCorrectQuotient()
    {
        // Arrange
        int a = 15;
        int b = 3;

        // Act
        double result = _calculator.Divide(a, b);

        // Assert
        Assert.Equal(5.0, result);
    }

    [Fact]
    public void Divide_ByZero_ThrowsDivideByZeroException()
    {
        // Arrange
        int a = 10;
        int b = 0;

        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Divide(a, b));
    }

    [Theory]
    [InlineData(2, true)]
    [InlineData(3, false)]
    [InlineData(0, true)]
    [InlineData(-2, true)]
    [InlineData(-3, false)]
    public void IsEven_VariousNumbers_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        bool result = _calculator.IsEven(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(0, 1)]
    [InlineData(1, 1)]
    [InlineData(5, 120)]
    [InlineData(3, 6)]
    public void Factorial_ValidNumbers_ReturnsCorrectResult(int n, int expected)
    {
        // Act
        int result = _calculator.Factorial(n);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Factorial_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        int n = -1;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Factorial(n));
    }
    #endregion

    #region Advanced Math Tests (Partial Coverage)
    [Theory]
    [InlineData(2, 3, 8)]
    [InlineData(5, 2, 25)]
    [InlineData(10, 0, 1)]
    [InlineData(2, -2, 0.25)]
    public void Power_VariousInputs_ReturnsCorrectResult(double baseNumber, double exponent, double expected)
    {
        // Act
        double result = _calculator.Power(baseNumber, exponent);

        // Assert
        Assert.Equal(expected, result, precision: 10);
    }

    [Theory]
    [InlineData(25, 5)]
    [InlineData(16, 4)]
    [InlineData(0, 0)]
    [InlineData(1, 1)]
    public void SquareRoot_ValidNumbers_ReturnsCorrectResult(double number, double expected)
    {
        // Act
        double result = _calculator.SquareRoot(number);

        // Assert
        Assert.Equal(expected, result, precision: 10);
    }

    [Fact]
    public void SquareRoot_NegativeNumber_ThrowsArgumentException()
    {
        // Arrange
        double number = -4;

        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.SquareRoot(number));
    }

    [Theory]
    [InlineData(48, 18, 6)]
    [InlineData(56, 42, 14)]
    [InlineData(17, 13, 1)]
    [InlineData(-12, 8, 4)]
    public void GreatestCommonDivisor_VariousInputs_ReturnsCorrectResult(int a, int b, int expected)
    {
        // Act
        int result = _calculator.GreatestCommonDivisor(a, b);

        // Assert
        Assert.Equal(expected, result);
    }

    // Note: LeastCommonMultiple is intentionally not tested to reduce coverage
    #endregion

    #region Number Theory Tests (Selective)
    [Theory]
    [InlineData(2, true)]
    [InlineData(3, true)]
    [InlineData(17, true)]
    [InlineData(29, true)]
    [InlineData(1, false)]
    [InlineData(4, false)]
    [InlineData(15, false)]
    [InlineData(25, false)]
    public void IsPrime_VariousNumbers_ReturnsCorrectResult(int number, bool expected)
    {
        // Act
        bool result = _calculator.IsPrime(number);

        // Assert
        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(1, new int[] { 0 })]
    [InlineData(2, new int[] { 0, 1 })]
    [InlineData(5, new int[] { 0, 1, 1, 2, 3 })]
    [InlineData(8, new int[] { 0, 1, 1, 2, 3, 5, 8, 13 })]
    public void FibonacciSequence_ValidCounts_ReturnsCorrectSequence(int count, int[] expected)
    {
        // Act
        var result = _calculator.FibonacciSequence(count);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void FibonacciSequence_ZeroOrNegativeCount_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.FibonacciSequence(0));
        Assert.Throws<ArgumentException>(() => _calculator.FibonacciSequence(-5));
    }
    #endregion

    #region Statistics Tests (Partial Coverage)
    [Fact]
    public void Average_ValidNumbers_ReturnsCorrectAverage()
    {
        // Arrange
        double[] numbers = { 10, 20, 30, 40, 50 };

        // Act
        double result = _calculator.Average(numbers);

        // Assert
        Assert.Equal(30, result);
    }

    [Fact]
    public void Average_EmptyArray_ThrowsArgumentException()
    {
        // Act & Assert
        Assert.Throws<ArgumentException>(() => _calculator.Average());
        Assert.Throws<ArgumentException>(() => _calculator.Average(null));
    }

    [Theory]
    [InlineData(new double[] { 1, 2, 3, 4, 5 }, 3)]
    [InlineData(new double[] { 1, 2, 3, 4 }, 2.5)]
    [InlineData(new double[] { 7 }, 7)]
    public void Median_VariousArrays_ReturnsCorrectMedian(double[] numbers, double expected)
    {
        // Act
        double result = _calculator.Median(numbers);

        // Assert
        Assert.Equal(expected, result);
    }

    // Note: Max and Min methods are intentionally not tested to reduce coverage
    #endregion

    #region Percentage Tests
    [Theory]
    [InlineData(25, 100, 25)]
    [InlineData(50, 200, 25)]
    [InlineData(75, 150, 50)]
    public void Percentage_ValidInputs_ReturnsCorrectPercentage(double value, double total, double expected)
    {
        // Act
        double result = _calculator.Percentage(value, total);

        // Assert
        Assert.Equal(expected, result);
    }

    [Fact]
    public void Percentage_ZeroTotal_ThrowsDivideByZeroException()
    {
        // Act & Assert
        Assert.Throws<DivideByZeroException>(() => _calculator.Percentage(50, 0));
    }
    #endregion

    #region Compound Interest Tests (Partial)
    [Fact]
    public void CalculateCompoundInterest_ValidInputs_ReturnsCorrectAmount()
    {
        // Arrange
        double principal = 1000;
        double rate = 0.05; // 5%
        int timesCompounded = 4; // quarterly
        double years = 2;

        // Act
        double result = _calculator.CalculateCompoundInterest(principal, rate, timesCompounded, years);

        // Assert
        Assert.Equal(1104.49, result, precision: 2);
    }

    // Note: Error cases for compound interest are intentionally not tested
    #endregion

    // Note: Temperature conversion methods (CelsiusToFahrenheit, FahrenheitToCelsius)
    // and distance conversion methods (MilesToKilometers, KilometersToMiles) 
    // are intentionally left untested to achieve partial coverage
}
