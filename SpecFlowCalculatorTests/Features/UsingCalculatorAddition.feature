Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator]($projectname$/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Addition
Scenario: Add two numbers
    Given I have a calculator
    When I have entered 50 and 70 into the calculator and press add
    Then the result should be 120
    
@Addition
Scenario Outline: Add zeros for special cases
    Given I have a calculator
    When I have entered <val1> and <val2> into the calculator and press add
    Then the result should be <val3>
    Examples: 
    | val1 | val2 | val3 |
    | 0    | 11   | 3    |
    | 10   | 11   | 11   |
    | 11   | 11   | 15   |
    

