using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowCalculatorTests.StepDefinitions;

[Binding]
public sealed class CalculatorMusaSteps
{
    private Calculator _calculator;
    public CalculatorMusaSteps(Calculator calculator)
    {
        this._calculator = calculator;
    }
    private double _result;
    [When(@"I have entered (.*),(.*)  and (.*) into the calculator and press basicMusa")]
    public void WhenIHaveEnteredAndCfiTheCalculator(double p0, double p1, double p2)
    {
        _result = _calculator.Multiply(p0, _calculator.Subtract(1,_calculator.Divide(p1,p2)));
    }
    
    [When(@"I have entered (.*), (.*) and (.*) into the calculator and press average number of expected failures")]
    public void WhenIHaveEnteredAndAnefTheCalculator(double p0, double p1,double p2)
    {
        _result = _calculator.Multiply(p0, _calculator.Subtract(1,Math.Exp(_calculator.Multiply(-_calculator.Divide(p1,p0),p2))));
    }

    [Then(@"the reliability result should be (.*)")]
    public void ThenReliabilityResultShouldBeOnTheScreen(double p0)
    {
        Assert.That(_result,Is.EqualTo(p0));
    }
}