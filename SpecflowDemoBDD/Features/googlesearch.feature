Feature: Contact_Us
  As an end user
  I want a contact us page
  So that I can find out more about QAWorks exciting services!!


Scenario Outline: Verify Valid Submission
    Given I am on the QAWorks contacts page
	When I send the "<Name>" Name "<Email>" Email "<Subject>" Subject "<Message>" Message
    Then I should see "Message send succesfully" 
	Examples: 
	| Name     | Email                | Subject         | Message                                   |
	| j.Bloggs | j.Bloggs@qaworks.com | test automation | please contact me I want to find out more |



Scenario Outline: Verify InValid Submission Validation
    Given I am on the QAWorks contacts page
	When I send the "<Name>" Name "<Email>" Email "<Subject>" Subject "<Message>" Message
    Then I should see "There was an error trying to send your message. Please try again later." 
	Examples: 
	| Name     | Email                | Subject         | Message                                   |
	| j.Bloggs | j.Bloggs@qaworks.com | test automation | please contact me I want to find out more |
   







