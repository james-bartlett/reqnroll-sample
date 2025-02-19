Feature: Calculator

Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first num is 50
	And the second num is 70
	When the two nums are added
	Then the output should be 120