Feature: Indeed Job Search

Job Search In Indeed

@IndeedSearch
Scenario: Software Tester
	Given Indeed Home Page
	When Search for Software Tester job post
	Then related Results Should display
