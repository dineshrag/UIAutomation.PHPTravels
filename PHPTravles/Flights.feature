Feature: Flights

Booking a flight in PHP Travels

Scenario: Booking a Flight in PHP Travels
	Given I have opened PHPTravels website
	Then I can click on Flights options
	And I choose trip as 'Roundtrip'
	And I enter cabin class as 'ECONOMY'
	And I can enter From City or Airport as 'Sydney Kingsford Smith'
	And I can enter To City or Airport as 'Chennai'
	And I ennter depature date as '28-06-2019'
	And I ennter arrivale date as '05-07-2019'
	And I click of number of passengers
	Then I enter number of Adults as '2'
	And I click on done
	Then I click on Search
	And I click on first available flight option 
	And I click on signin 
	And I enter username and password details
	Then I enter passenger Name 'Dinesh'
	And I enter passenger age '26'
	And I enter passenger passport number 'NB154266'
	And I enter confirm booking
	Then I verify the invoice



