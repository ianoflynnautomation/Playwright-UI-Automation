Feature: Login

@regression
Scenario: Active user can log in successfully
	Given I navigate to the website home page
	When I login with a valid users credentials
		| UserName      | Password     |
		| standard_user | secret_sauce |
	Then the user should be logged in successfully

@regression
Scenario: Locked Out user can NOT log in successfully
	Given I navigate to the website home page
	When I login with a valid users credentials
		| UserName        | Password     |
		| locked_out_user | secret_sauce |
	Then the user should not be logged in

@regression
Scenario: Problem user can log in successfully
	Given I navigate to the website home page
	When I login with a valid users credentials
		| UserName     | Password     |
		| problem_user | secret_sauce |
	Then the user should be logged in successfully

@regression
Scenario: Performance Glitch user can log in successfully
	Given I navigate to the website home page
	When I login with a valid users credentials
		| UserName                | Password     |
		| performance_glitch_user | secret_sauce |
	Then the user should be logged in successfully