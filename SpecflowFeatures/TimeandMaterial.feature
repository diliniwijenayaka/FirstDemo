Feature: TimeandMaterial
	As a logged in user in the portal
	I want successfully
	add, edit and delete Time and Materiel 

@mytag
Scenario: Logged in user should be able to Add Time and Material 
	Given I have logged into the portal
	And I have navigated to the Time and Material Page
	Then I have added Time and Material successfully

	Scenario: Logged in user should be able to Edit the added Time and Material
	Given I have logged into the portal
	And I have navigated to the Time and Material Page
	Then I have added Time and Material successfully
	Then I have edited the added Time and Material Successfully

	Scenario: Logged in user should be able to Delete the added Time and Material 
	Given I have logged into the portal
	And I have navigated to the Time and Material Page
	Then I have added Time and Material successfully
	Then I have edited the added Time and Material Successfully
	Then I have deleted the edited Time and Materil successfully
