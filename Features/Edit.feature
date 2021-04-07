Feature: Edit Profile
	Simple calculator for adding two numbers

@Edit
Scenario: Edit Existing Languages
	Given User logs in
	When Edit and save Language
	Then Updated Language is saved

	Scenario: Edit Existing Skills
	Given User logs in
	When Edit and save skill
	Then Updated skill is saved

#	Scenario: Edit Existing Education
#	Given User logs in
#	When Edit and save Education
#	Then Updated Education is saved
#
#	
#Scenario: Edit Existing Certification
#	Given User logs in
#	When Edit and save Certification
#	Then Updated Certification is saved


