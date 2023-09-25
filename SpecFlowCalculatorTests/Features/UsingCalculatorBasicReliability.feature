Feature: UsingCalculatorBasicReliability
    In order to calculate the Basic Musa model's failures/intensities
    As a Software Quality Metric enthusiast
    I want to use my calculator to do this
    
    
@BasicMusa
Scenario: Calculating Current Failure Intenstiy
    Given I have a calculator
    When I have entered 10, 50  and 100 into the calculator and press basicMusa
    Then the reliability result should be 5
   
    
@BasicMusa
Scenario: Calculating Average Number of Expected Failures
    Given I have a calculator
    When I have entered 100, 10 and 10 into the calculator and press average number of expected failures
    Then the reliability result should be 63