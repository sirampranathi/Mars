Feature: 3Profile
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@positivescenario
Scenario: 1.1Add Language in Profile New
Given User is loggedIn and is in profile page
And  User is in language tab
And  User clicks on Add new and Enters the language details 
When User clicks on Add
Then Language should be added to the profile


@positivescenario
Scenario: 1.2Add Skills in profile 
Given User is loggedIn and is in profile page
And User navigates to Skills tab and selects Add New
And User enters skill and chooses Skill level
When User clicks on Add button
Then Skill should be added to the profile


@positivescenario
Scenario: 1.3Add Education in profile 
Given User is loggedIn and is in profile page
And User navigates to Education tab  and selects Add New
And User enters all the required education details 
When User clicks on Add button
Then Education should be added to the profile

@positivescenario
Scenario: 1.4Add certification in profile 
Given User is loggedIn and is in profile page
And User navigates to certification tab  and selects Add New
And User enters certification details and selects year
When User clicks on Add button
Then Certification should be added to the profile


@positivescenarios
Scenario: 1.5Edit added language in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Language tab and User has languages added 
	And User clicks on Edit icon and Edits selected language
	When User clicks on update button in language tab
	Then edited language should be updated in the profile page

@positivescenarios
Scenario: 1.6Edit added Skill in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Skill tab and User has Skills added 
	And User clicks on Edit icon and Edits selected skill details
	When User clicks on update button in skill tab
	Then edited skill should be updated in the profile page


@positivescenarios
Scenario: 1.7Edit added Education in Profile
	Given User is LoggedIn and is in Profile page
	And User is in Education tab and User has Education added 
	And User clicks on Edit icon and Edits selected Education details
	When User clicks on update button in Education tab
	Then edited education details should be updated in the profile page


@positivescenarios
Scenario: 1.8Edit added certification in Profile
	Given User is LoggedIn and is in Profile page
	And User is in certificate tab and User has certifications added 
	And User clicks on Edit icon and Edits selected certificate details
	When User clicks on update button in certificate tab
	Then edited certificate details should be updated in the profile page

@postiviescenario
Scenario: 1.9Delete added language in profile page 
	Given User is logged in and is in profile page
	And User has languge added to the profile
	When  User clicks on Delete icon of a language
	Then particular language should be removed from the user profile


@positive scenario
Scenario: 2.0Delete added Skill in profile page 
	Given User is logged in and is in profile page
	And User has Skill added to the profile
	When  User clicks on Delete icon of a Skill
	Then particular skill should be removed from the user profile


@positive scenario
Scenario: 2.1Delete added Education in profile page 
	Given User is logged in and is in profile page
	And User has Education added to the profile
	When  User clicks on Delete icon of a Education 
	Then particular education details should be removed from the user profile

@positive scenario
Scenario:2.2 Delete added Certification in profile page 
	Given User is logged in and is in profile page
	And User has certification added to the profile
	When  User clicks on Delete icon of a Certificate 
	Then particular certification details should be removed from the user profile



