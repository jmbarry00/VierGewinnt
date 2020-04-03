Feature: Spielfeld

@mytag
Scenario: set Position of "Spielstein"
	Given I have entered 4 into the x-position(spalte) setter
	When I call the function FeldIstBesetzt on this position  
	Then result should be true