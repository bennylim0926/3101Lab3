using NUnit.Framework;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class CalculatorDefectDensityStep
{
    private Calculator _calculator;
    public CalculatorDefectDensityStep(Calculator calculator)
    {
        this._calculator = calculator;
    }
    private double _result;

    [When(@"I have entered (.*) and (.*) into the calculator and press dd")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndDd(double p0,double p1)
    {
        _result = _calculator.Divide(p0, p1);
    }
    
    [Then(@"the defect density should be (.*)")]
    public void ThenTheDdResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}