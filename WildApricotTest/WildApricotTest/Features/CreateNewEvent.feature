Feature: CreateNewEvent
	Feature to test Create New Simple Event page functionality

Background: 
	Given I navigate to application web page
		And I enter username and password on application web page
		| UserName					 | Password	|
		| peoplepower32@yandex.ru    | fas55fas |
		And I click login on application web page
		And I switch to admin view from application web page
		And I navigate to Events menu on admin view page		

Scenario: Provide a valid information to create new simple event
	Given I create new simple event on Event list
	When I enter title 'New fancy title' for new simple event
		And I enter tags 'Tag.Tag.Tag' for new simple event
		And I enter location 'Fun location' for new simple event
		And I enter start date '30 May 2018' for new simple event
		And I enter end date '30 May 2019' for new simple event
		And I enter start time '5' for new simple event
		And I enter end time '10' for new simple event
		And I choose enabled status for new simple event
		And I enter available period from '30 Jun 2018' for new simple event
		And I enter available period through '30 Jun 2019' for new simple event
		And I allow guest registrations for new simple event
		And I limit guests to '5' for new simple event
		And I do not allow cancellation by registrants for new simple event
		And I choose to show registrations who want to be listed to members only for new simple event



		


