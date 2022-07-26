Feature: Square

A short summary of the feature

@mysquare
Scenario: Find square area
	Given side of square is <side>
	When we want to find its area
	Then the square area should be <area>

	Examples:
		| side | area |
		| 1    | 1    |
		| 2    | 4    |
		| 3    | 9    |
		| 90   | 8100 |

