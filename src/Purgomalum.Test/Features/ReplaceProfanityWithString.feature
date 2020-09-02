Feature: Replace_Profanity_With_String
	As a person who is a little bit delicate
    I would like to have words of profanity replaced with something nice in incomming texts
    So that I can ignore all the negativity


Background:
    Given The profanity removing API is available


Scenario Outline: No_Profanity_Replaced_With_String
    Given I am using the profanity string replacement service with <replacementString>
    When I receive an incomming text of <text>
    And I replace profanitys in the content
    Then the <text> remains unchanged

Examples:
    | replacementString     | text              |
    | lovelyness            | you're nice       |  
    | warm hugs             | badger mushroom   |


Scenario Outline: Profanity_Replaced_With_String
    Given I am using the profanity string replacement service with <replacementString>
	When I receive an incomming text of <text>
    And I replace profanitys in the content
    Then the string of <replacementString> is added

Examples:
    | replacementString     | text        |
    | flowers               | fuck off    |
    | chocolates            | badger twat |