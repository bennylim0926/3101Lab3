using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class CalculatorAvailabilityStep
{
    private Calculator _calculator;
    public CalculatorAvailabilityStep(Calculator calculator)
    {
        this._calculator = calculator;
    }
    private double _result;
    [When(@"I have entered (.*) and (.*) into the calculator and press MTBF")]
    public void WhenIHaveEnteredAndMBTFTheCalculator(double p0, double p1)
    {
        _result = _calculator.Add(p0, p1);
    }
    
    [When(@"I have entered (.*) and (.*) into the calculator and press Availability")]
    public void WhenIHaveEnteredAndAvailabilityTheCalculator(double p0, double p1)
    {
        _result = _calculator.Divide(p0, p1);
    }

    [Then(@"the availability result should be (.*)")]
    public void ThenTheAvailabilityResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result,Is.EqualTo(p0));
    }
    
}