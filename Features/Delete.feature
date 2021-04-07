Feature: Delete Profile
	Simple calculator for adding two numbers

@Delete

Scenario: Delete Languages
	Given  User logged in to Mars
	When Delete Language
	Then Language is deleted

Scenario: Delete skill
	Given User logged in to Mars
	When Delete skill
	Then skill is deleted

Scenario: Delete Certification
	Given User logged in to Mars
	When Delete Certification
	Then skill is Certification

Scenario: Delete Education
	Given User logged in to Mars
	When Delete Education
	Then skill is Education