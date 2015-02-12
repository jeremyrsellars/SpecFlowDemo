Feature: AddingCalculator
  In order to avoid silly mistakes
  As a math idiot
  I want to be told the sum of two numbers and the awesomeness to ensue without further fuss
  So this is a simple post-fix calculator.  Think of it as a list of numbers.  When you press an button like add or subtract, all the numbers in the list are added or subtracted.

# Adding numbers

@mytag
Scenario: Add before entering any numbers
  When I press add
  Then the result should be 0 on the screen

Scenario: Add two numbers
  Given I have entered 50 into the calculator
  And I have entered 70 into the calculator
  When I press add
  Then the result should be 120 on the screen

Scenario: Add 8 negative numbers
  Given I have entered -100 into the calculator
  And I have entered -100 into the calculator
  And I have entered -100 into the calculator
  And I have entered -100 into the calculator
  And I have entered -100 into the calculator
  And I have entered -100 into the calculator
  And I have entered -100 into the calculator
  And I have entered -100 into the calculator
  When I press add
  Then the result should be -800 on the screen

# Subtracting Numbers

Scenario: Subtract 0 numbers
  Given I press subtract
  Then the result should be 0 on the screen

Scenario: Subtract 3 numbers
  Given I have entered 4 into the calculator
  And I have entered 3 into the calculator
  And I have entered 2 into the calculator
  And I press subtract
  Then the result should be 2 on the screen because the first number isn't subtracted - it's as if the operator is put between each operand.

# Combinations
Scenario: Add 2 numbers Then Subtract a number
  Given I have entered 10 into the calculator
  And I have entered 3 into the calculator
  And I press add
  And I have entered 2 into the calculator
  And I press subtract
  Then the result should be 11 on the screen
