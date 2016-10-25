Feature: Specflow_Excel_SampleTest

@smoke
Scenario Outline:Go To Login Page
	Given User is at homepage <url>
	When User clicks on Login
	Then User is navigate to Login Page

	@source:DataResources\TestData.xlsx
	Examples: 
	| url                         |





