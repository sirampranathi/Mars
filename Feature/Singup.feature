Feature: Singup
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Join the ShareSkill page with all the valid details
    Given Enter  First name, Last name
	And   Enter Valid Email , Password with minimum 6 charaters and confirm password
	When  tick terms and conditions and click join
	Then  Message displayed "registered succesfully" 

Scenario: Join the Shareskills with empty FirstName
    Given Enter null First name, valid Last name
	And Enter Valid Email , Password with minimum 6 charaters and confirm password
	When Tick terms and conditions and click join
	Then show error message "This field is required"near Firstname

Scenario: Join the Shareskills with empty lastname
    Given Enter valid First name, null Last name
	And Enter Valid Email , Password with minimum 6 charaters and confirm password
	When Tick terms and conditions and click join
	Then show error message "This field is required" near Lastname

	Scenario: Join the Shareskills with empty FirstName and Last name
    Given Enter null First name, null Last name
	And Enter Valid Email , Password with minimum 6 charaters and confirm password
	When Tick terms and conditions and click join
	Then show error message "This field is required" for both the fields

	Scenario: Join the Shareskills with invalid email
    Given Enter First name, Last name
	And Enter inValid Email , valid Password with minimum 6 charaters and confirm password
	When Tick terms and conditions and click join
	Then show error message "please enter valid email address" near email 
	
	Scenario: Join the Shareskills with invalid password
    Given Enter First name,  Last name
	And Enter Valid Email and Password less than 6 charaters and confirm password
	When Tick terms and conditions and click join
	Then show error message "Password must be atleast 6 characters" near Password
	
	Scenario: Join the Shareskills with blank password
    Given Enter First name and Last name
	And Enter Valid Email and blank Password and blank confirm password
	When Tick terms and conditions 
	Then click join and user must not be able to register
	
	Scenario: Join the Shareskills with wrong confirm password
    Given Enter First name, Last name
	And Enter Valid Email , Password with minimum 6 charaters and enter wrong confirm password
	When Tick terms and conditions and click join
	Then show error message "Does not match password"near confirm password field

	Scenario: Join the Shareskills without ticking Terms and Conditions
    Given Enter  First name, valid Last name
	And Enter Valid Email and valid Password with minimum 6 charaters and confirm password
	When  Terms and conditions are not ticked and click join
	Then show error message "You must agree terms and conditions" near tick box
	
	Scenario: "Click on login near Already have an acoount"
    Given Enter valid user name 
	And Enter  valid Password 
	When  click on login
	Then user must be logged in 







