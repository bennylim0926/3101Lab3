using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class CalculatorMusaLog
{
    private Calculator _calculator;
    public CalculatorMusaLog(Calculator calculator)
    {
        this._calculator = calculator;
    }
    private double _result;

    [When(@"I have entered (.*),(.*) and (.*) into the calculator and press log musa")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndLogMusa(double p0,double p1,double p2)
    {
        _result = _calculator.Multiply(p0, Math.Exp(_calculator.Multiply(-p1,p2)));
    }
    
    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press log musa mean of expected failures")]
    public void WhenIHaveEnteredAndIntoTheCalculatorAndLogMusaReliability(double p0,double p1, double p2)
    {
        _result = _calculator.Multiply(_calculator.Divide(1,p1), Math.Log(_calculator.Add(_calculator.Multiply(_calculator.Multiply(p0,p1),p2),1)));
    }
    
    [Then(@"the musa log reliability result should be (.*)")]
    public void ThenTheLogMusaResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(Math.Round(_result,2), Is.EqualTo(p0));
    }
}