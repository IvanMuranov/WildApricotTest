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

Scenario: 01 Check that providing valid information for simple event creation it will be created properly
	Given I create new simple event on Event list
	When I enter title 'New fancy title' for new simple event
		And I enter tags 'tag.tag.tag' for new simple event
		And I enter location 'Fun location' for new simple event
		And I enter start date '30 May 2018' for new simple event
		And I enter end date '30 May 2019' for new simple event
		And I enter start time '5:00 AM' for new simple event
		And I enter end time '10:00 AM' for new simple event
		And I choose Enabled status for new simple event
		And I enter available period from '30 Jun 2018' for new simple event
		And I enter available period through '30 Jul 2018' for new simple event
		And I allow guest registrations for new simple event
		And I limit guests to '5' for new simple event
		And I do not allow cancellation by registrants for new simple event
		And I choose not to show registrations who want to be listed for new simple event
		And I save new simple event
	Then I check that created simple event have title 'New fancy title'
		And I check that created simple event have tags 'tag.tag.tag'
		And I check that created simple event have location 'Fun location'
		And I check that created simple event have time zone '(UTC+03:00) Baghdad'
		And I check that created simple event have date and time '30 May 2018, 5:00 AM – 30 May 2019, 10:00 AM'
		And I check that created simple event have Enabled status
		And I check that created simple event have available period 'From 30 Jun 2018 through 30 Jul 2018 (61 days after start of event)'
		And I check that created simple event have allowed guests
		And I check that created simple event have guests limit as '5 per registrant'
		And I check that created simple event do not allow cancellation
		And I check that created simple event will not show registrations who want to be listed

Scenario: 02 Check that From and Through dates must be earlier than event end date and exception will be displayed
	Given I create new simple event on Event list
	When I enter title 'New fancy title' for new simple event		
		And I enter start date '30 May 2018' for new simple event
		And I enter end date '30 May 2019' for new simple event		
		And I enter available period from '30 Jun 2018' for new simple event
		And I enter available period through '30 Jun 2019' for new simple event		
		And I save new simple event
	Then I check that error 'From and Through dates must be earlier than event end date' is displayed during the simple event creation
		

Scenario: 03 Check that End date can not be earlier than start date
	Given I create new simple event on Event list
	When I enter title 'New fancy title' for new simple event		
		And I enter start date '30 May 2019' for new simple event
		And I enter end date '30 May 2018' for new simple event
		And I save new simple event
	Then I check that error 'End date and time can not be earlier than start date and time' is displayed during the simple event creation



		


