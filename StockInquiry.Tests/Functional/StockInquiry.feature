Feature: Stock inquiry
	In order to sell to a customer
	As a store person
	I want to be able to look up the location of stock

Background: 
	Given I know stock exists for Ben Sherman's Entire Range
	And I want to make a stock inquiry

Scenario: Simple stock inquiry
	When I search for the style "Ben Sherman Shirt"
	Then I should see the SKU's for "All Ben Sherman's Shirts"

	When I choose to look at stock for a "Ben Sherman Shirt In Medium Black"
	Then I should see all the "Ben Sherman Shirt In Medium Black" stock