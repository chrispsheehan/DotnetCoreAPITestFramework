Feature: Replace_Profanity_With_Character
	As a person who is a little bit delicate
    I would like to have words of profanity replaced with some characters
    So that I am not exposed to bad things


Background:
    Given The profanity removing API is available


Scenario Outline: No_Profanity_Replaced_With_Character
    Given I am using the profanity character replacement service with <replacementCharacter>
	When I receive an incomming text of <text>
    And I replace profanitys in the content
    Then the <text> remains unchanged

Examples:
    | replacementCharacter  | text              |
    | _                     | you're nice       | 
    | ~                     | badger mushroom   |


Scenario Outline: Profanity_Replaced_With_Character
    Given I am using the profanity character replacement service with <replacementCharacter>
	When I receive an incomming text of <text>
    And I replace profanitys in the content
    Then replaced profanity with the corresponding amount of <replacementCharacter>    

Examples:
    | replacementCharacter  | text        |
    | -                     | fuck off    |
    | =                     | badger twat |