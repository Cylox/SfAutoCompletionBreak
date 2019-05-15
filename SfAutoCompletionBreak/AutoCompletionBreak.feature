Feature: AutoCompletionBreak
		When using an escaped parenthesis in a specflow step attribute regex like this: '\(' the auto completion
		only will insert the step text up to the first backslash


Scenario: Try to insert step text though auto completion
	Given I have a step with coordinates like this: \{x}
