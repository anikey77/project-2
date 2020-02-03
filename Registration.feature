Feature: Registration
	In order to Use Giftrete Website
	I need to register

	Background: 
	Given I Navigate to giftrete website
	    And And I click on Create Account

@mytag
Scenario:Registration
	When I Enter my firstname 
	    And I enter Lastname 
	    And Ienter my Email address 
		And I Select Country
	    And I Enter my password 
	    And I confirm my Password 
	    And I Click Captcha 
	    And I Click register 
	Then I am registered

Scenario:Registration With parameter
	When I Enter my firstname "kudirat"
	    And I enter Lastname "Ajimajasan"
	    And Ienter my Email address "email"
		And I Select Country
	    And I Enter my password "korede"
	    And I confirm my Password 
	    And I Click Captcha 
	    And I Click register
	Then I am registered

Scenario Outline: Invalid Registration with parameter
	      When I Enter my firstname "<Firstname>"
	         And I enter Lastname "<Lastname>"
	         And Ienter my Email address "<Email>"
             And I Select Country
	         And I Enter my password "<Password>"
	         And I confirm my Password
	         And I Click Captcha 
	         And I Click register
	     Then I am not registered

	Examples: 
	| Firstname | Lastname   | Email                     | Password |Country         |
	| Kudirat   | Ajimajasan | kudidebay@yahoo.com       | korede   | United Kingdom |
	| Samuel    | Ajimajasan | samuelsina2002@yahoo.com  | faith2   | United Kingdom |


	
