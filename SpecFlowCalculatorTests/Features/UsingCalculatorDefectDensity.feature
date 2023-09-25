Feature: UsingCalculatorDefectDensity	

@DefectDensity
Scenario: Calculating defect density when defect > 0
	Given I have a calculator
	When I have entered <val1> and <val2> into the calculator and press dd
	Then the defect density should be <val3>
	Examples: 
	| val1 | val2 | val3 |
	| 0    | 100  | 0    |
	| 1000 | 10   | 100  |
 

