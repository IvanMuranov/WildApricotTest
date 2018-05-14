Feature: CreateNewEvent
	Feature to test Create New Simple Event page functionality

Scenario: Provide a valid information to create new simple event
	Given I navigate to application web page
		And I enter username and password on application web page
		| UserName					 | Password	|
		| peoplepower32@yandex.ru    | fas55fas |
		And I click login on application web page
		And I switch to admin view from application web page
		And I navigate to Events menu on admin view page
		And I create new event on Event list



		


