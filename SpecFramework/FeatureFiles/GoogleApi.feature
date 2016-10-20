Feature: GoogleGeoCode
	To test the latitude and longgitude for location


Scenario Outline: Verify Latitude and Longitude 
	Given Google api that takes address and returns latitude and longitude
	When The client Gets response by <address>
	Then The < Latitude> and <Longitude> returned should be as expected

	@source:DataResources\APIData.xlsx
	Examples: 
	| address                                      | Latitude   | Longitude |


