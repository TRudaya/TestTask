Feature: Home page tests

@test1
Scenario: User be able to see Logo
	Given the Vsitor opens 'Home' page
	Then 'Site' logo is displayed to The Visitor

@test2
Scenario: Checks greetings for the newcommers
	Given the Vsitor opens 'Home' page
	Then greeting message should be correct for different times of the day

@test5
Scenario: Checks the 'Восстановить пароль' button
	Given the Vsitor opens 'Home' page
	Then the 'Восстановить пароль' button should be on page