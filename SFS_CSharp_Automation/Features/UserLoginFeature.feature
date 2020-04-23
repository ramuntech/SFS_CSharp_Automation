Feature: User Login
	As a User
	I can verify userlogin with valid credentials

@smoke
Scenario: Validate user login with valid credentials
	Given I am in login page
	When I performLogin with 'malli' and '123'
	Then I can vrify homepage after login

Scenario: Validate user login with invalid credentials
	Given I am in login page
	When I performLogin with 'malli' and '123'
	Then I can vrify homepage after login
