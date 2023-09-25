Feature: UsingCalculatorFactorial
	In order to conquer factorial
	As a calculator user
	I want to be told the result of factorial

@Factorial
Scenario: Factorial
	Given I have a calculator
	When I have entered <val1> into the calculator and press factorial
	Then the factorial result should be <val2>
	Examples: 
	  | val1 | val2 | 
	  | 0    | 1    | 
	  | 3    | 6    |
	  | 5    | 120  |