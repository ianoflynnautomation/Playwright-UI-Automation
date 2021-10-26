Feature: Login

@mytag
Scenario: Active user can log in successfully
	Given I navigate to the website home page
	When I login with a valid users credentials
		| UserName      | Password     |
		| standard_user | secret_sauce |  
	Then the user should be logged in successfully