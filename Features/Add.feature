Feature: Add Profile details 

Link to a feature: [Add profile dteails](MarsOnboardingTask/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Add
Scenario: Add Description on Profile Page
	Given User is logged in to Mars
	When Add Profile description
	Then The details should be saved
	
Scenario: Add New Languages
	Given User is logged in to Mars
	When Add New Language
	Then New Language is saved

Scenario: Add New Skills
	Given User is logged in to Mars
	When Add New skill
	Then New skill is saved

Scenario: Add New Education
	Given User is logged in to Mars
	When Add New Education
	Then New Education is saved

Scenario: Add New Certification
	Given User is logged in to Mars
	When Add New Certification
	Then New Certification is saved

	