Feature: Replace_Profanity_With_String
	As a person who is a little bit delicate
    I would like to have words of profanity replaced with something nice in incomming texts
    So that I can ignore all the negativity


Background:
    Given The profanity removing API is available
    And I am using the profanity string replacement service


Scenario Outline: No_Profanity_Replaced_With_String
    When I receive an incomming message of <text>
    And I process the content
    Then the <text> remains unchanged

Examples:
    | text              |
    | you're nice       |  
    | badger mushroom   |


Scenario Outline: Profanity_Replaced_With_String
	When I receive an incomming text of <text>
    And I process the content
    Then the <replacementString> is added

Examples:
    | replacementString     | text        |
    | flowers               | fuck off    |
    | chocolates            | badger twat |