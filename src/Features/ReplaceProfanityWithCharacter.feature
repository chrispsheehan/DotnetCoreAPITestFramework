Feature: Replace_Profanity_With_Character
	As a person who is a little bit delicate
    I would like to have words of profanity replaced with some characters
    So that I am not exposed to bad things


Background:
    Given The profanity removing API is available
    And I am using the profanity character replacement service


Scenario Outline: No_Profanity_Replaced_With_Character
	When I receive an incomming text of <text>
    And I process the content
    Then the <text> remains unchanged

Examples:
    | text              |
    | you're nice       | 
    | badger mushroom   |


Scenario Outline: Profanity_Replaced_With_Character
	When I receive an incomming text of <text>
    And I process the content
    Then replaced profanity with the corresponding amount of <replacementCharacter>    

Examples:
    | replacementCharacter  | text        |
    | []                    | fuck off    |
    | ()                    | badger twat |