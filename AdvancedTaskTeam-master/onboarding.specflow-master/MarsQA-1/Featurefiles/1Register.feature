Feature: 1Register


@mytag
Scenario: User has to Signup
	Given User has launched website
	And  Clicks on Join button
	And Enters all the required data
	When Pressed on Join Submit button
	Then Registration successfull confirmation message should be displayed 
