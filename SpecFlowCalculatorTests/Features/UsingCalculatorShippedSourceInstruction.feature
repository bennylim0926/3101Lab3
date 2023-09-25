Feature: UsingCalculatorShippedSourceInstruction

@ShippedSourceInstruction
Scenario: Calculating shipped source instruction
    Given I have a calculator
    When I have entered 200 and 10 into the calculator and press ssi
    Then the shipped source instruction should be 210
