using NUnit.Framework;
namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public class CalculatorDivisionStepDefinitions
{
    private Calculator _calculator;
    public CalculatorDivisionStepDefinitions(Calculator calculator)
    {
        this._calculator = calculator;
    }
    
    private double _result;
    [When(@"I have entered (.*) and (.*) into the calculator and press divide")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndDivide(double p0, double p1)
    {
        _result = _calculator.Divide(p0, p1);
    }
    
    [Then(@"the division result should be (.*)")]
    public void ThenTheDivisionResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
        
    [Then(@"the division result equals positive_infinity")]
    public void ThenTheDivisionResultShouldBePositiveInfinity()
    {
        Assert.That(_result, Is.EqualTo(Double.PositiveInfinity));
    }
}