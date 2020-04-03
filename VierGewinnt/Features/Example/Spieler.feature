Feature: Spieler
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: set Position of "Spielstein"
	Given I have entered 4 into the x-position(spalte) setter
	And I have set the name of the player who is true
	When I press add 
	Then the players should switch
