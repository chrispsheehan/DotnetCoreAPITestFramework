Feature: Find_Profanity
	As a person who is a little bit delicate
    I would like to have warning that there may be naughty words
    So that I can sit down before fainting


Background:
    Given The profanity removing API is available


Scenario Outline: No_Profanity_Found
	When I receive an incomming text of <text>
    And run it through the profanity API
    Then no profanitys are found

Examples:
| text          |
| hallow        |     
| hallow you    | 


Scenario Outline: Profanity_Found
	When I receive an incomming text of <text>
    And run it through the profanity API
    Then profanitys are found

Examples:
| text      |
| fuck      |  
| fuck off  | 