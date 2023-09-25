using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class CalculatorShippedSourceCode
{
    private Calculator _calculator;
    public CalculatorShippedSourceCode(Calculator calculator)
    {
        this._calculator = calculator;
    }
    private double _result;

    [When(@"I have entered (.*) and (.*) into the calculator and press ssi")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndSsi(double p0,double p1)
    {
        _result = _calculator.Add(p0, p1);
    }
    
    [Then(@"the shipped source instruction should be (.*)")]
    public void ThenTheSsiResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result, Is.EqualTo(p0));
    }
}