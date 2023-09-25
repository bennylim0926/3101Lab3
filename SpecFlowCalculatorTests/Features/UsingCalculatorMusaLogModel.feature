Feature: UsingCalculatorMusaLogModel	

@LogMusa
Scenario: Calculating Current Failure Intenstiy with log model
    Given I have a calculator
    When I have entered 10, 0.02  and 50 into the calculator and press log musa
    Then the musa log reliability result should be 3.68


@LogMusa
Scenario: Calculating Average Number of Expected Failures with log model
    Given I have a calculator
    When I have entered 10, 0.02 and 10 into the calculator and press log musa mean of expected failures
    Then the musa log reliability result should be 54.93