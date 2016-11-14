Feature: SampleUITest_usingTables
	To Test navigation from home to login page

@test
Scenario Outline:Go To Login Page
	Given User is at homepage <url>
	When User clicks on Signin
	Then User is navigate to Login Page
	When User clicks on rider signin
	Then User is at ridersignin page

	Examples: 
	| url                         |
	| https://www.uber.com/en-IN/ |

@ignore 
Scenario Outline:  Test navigation of rider sign in
	Given User being at login page <newurl>
	When User clicks on rider signin 
	Then User is at ridersignin page

	Examples: 
	| newurl                              |
	| https://www.uber.com/en-IN/sign-in/ |
