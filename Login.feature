Feature: Login
	As a registered giftrete user
	I need to login to be able to access the webwsite


	Backgrand:
	Given I navigate to Giftrete website
	And I click on login botton


@mytag
Scenario Outline: Valid Login with parameter
	
	When I enter valid email "<Email>"
	And I Enter valid password "<Password>"
	Then I should be logged in.

	Examples: 
	| Email          | Password |
	| kudidebay      | korede   |
	| kudyajimajasan | faith06  |

	
	Scenario: Invalid Login
	When I leave both email and password blank
	Then I should not be logged in


	Scenario: Negative Login
	When I enter valid email 
	And I enter Wrong password 
	Then I should not be logged in
