using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class CalculatorFactorialStep
{
    private Calculator _calculator;
    public CalculatorFactorialStep(Calculator calculator)
    {
        this._calculator = calculator;
    }
    private double _result;
    
    [When(@"I have entered (.*) into the calculator and press factorial")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndFactorial(double p0)
    {
        _result = _calculator.Factorial(p0);
    }
    
    [Then(@"the factorial result should be (.*)")]
    public void ThenTheFactorialResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}