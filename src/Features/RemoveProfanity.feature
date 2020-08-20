Feature: Remove_Profanity
	As a person who is a little bit delicate
    I would like to have words of profanity hidden from incomming text
    So that I can get on with my life without fainting


Background:
    Given The profanity removing API is available


Scenario Outline: No_Profanity_Removed
	When I receive an incomming text of <text>
    And run it through the profanity API
    Then no asterisks are added 

Examples:
| text          |
| hallow        |     
| hallow you    | 


Scenario Outline: Profanity_Removed
	When I receive an incomming text of <text>
    And run it through the profanity API
    Then replaced with the corresponding amount of asterisks

Examples:
| text      |
| fuck      |  
| fuck off  | 