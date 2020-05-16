Feature: login
	In order to avoid silly mistakes
	As a math idiot
	I want to login to the skill page

@mytag
Scenario: login to the share skill page
	Given I sign in to the website
	When I enter login details
	Then I logged in
	
	#Scenario: login to the share skill page with invalid details
	Given click on  sign in button
	When I enter invalid login details
	Then user should not be logged in alternote displayed"enter valid email"

	#Scenario: login to the share skill page with valid username invalid password
	Given click on sign in 
	When I enter  valid username and invalid password
	Then pop up displayed "confirm your email" and"send verification email"

	#Scenario: login to the share skill page with invalid username valid password
	Given click on sign in 
	When I enter  invalid username and valid password
	Then alter note with "please enter valid email "
	



