Feature: Profilesteps
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add Language deatails
	Given Select Language Tab
	And Click on Addnew
	When Enter new Language and Level
	Then Click Add button

	Scenario: Edit Language deatails
	Given Click Edit button
	When Update current record
	Then Click Update button

	Scenario: Delete Language deatails
	Given Click on Delete button
	Then Pop up displayed

	#Scenario: Add Skill deatils
	Given Select Skills Tab
	And Click on Addnew button
	When Enter new skills and Level
	Then Click Add button to add skills
	When Click on Cancel button
	Then Adding action is cancelled


	#Scenario: Edit Skill details
	Given Click Edit button to update existing skills
	When Update existing record
	Then Click Update and existing record is updated
	When Click on Cancel button
	Then Update action  cancelled


	#Scenario: Delete Skill details
	Given Click on Delete icon
	Then Displayed "skill is deleted" massage
	When click on Cancel button
	Then Deleting action is cancelled


	#Scenario: Add Education deatils
	Given Select education Tab
	And  Click on Addnew button
	When Enter new education details for all the fields
	Then Click Add button to add the details

	#Scenario: Edit Education details
	Given Click Edit button to update existing education details
	When Update existing record
	Then Click on Update button 
	When click on Cancel button
	Then Updation is  cancelled


	#Scenario: Delete Education details
	Given Click on Delete icon
	Then Displayed delete massage
	When click on Cancel button
	Then Deletion cancelled



	#Scenario: Add certification deatils
	Given Select certification Tab
	And Click on Addnew button
	When Enter new certification deatils and select year
	Then Click Add button to add certification deatils

	#Scenario: Edit certification details
	Given Click Edit button to update existing certification deatils
	When Update existing record
	Then Click Update button to save
	When click on Cancel button
	Then Updation is  cancelled



	#Scenario: Delete certification details
	Given Click on Delete icon
	Then Displayed delete massage
	When click on Cancel button
	Then Deletion cancelled





