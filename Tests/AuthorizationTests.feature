Feature: Authorization tests

@test3
Scenario Outline: Checks the Visitor be able to login (positive scenario)
	Given the Vsitor opens 'Home' page
	When the Visitor has logged in with credentials
		| User    | Password   |
		| <Login> | <Password> |
	Then the Visitor should be logged in system

	Examples: 
	| Login     | Password      |
	| ValidName | ValidPassword |

@test4
Scenario Outline: Checks the Visitor not be able to login (negative scenario)
	Given the Vsitor opens 'Home' page
	When the Visitor has logged in with credentials
		| User    | Password   |
		| <Login> | <Password> |
	Then the Visitor should not be logged in system

	Examples: 
	| Login       | Password        |
	| ValidName   | InvalidPassword |
	| InvalidName | ValidPassword   |
	| InvalidName | InvalidPassword |


@test6
Scenario Outline: Checks the Visitor not be able to register (positive scenario)
	Given The Visitor clicks on 'Sign In' button
	Then the Visitor should be on Register page
