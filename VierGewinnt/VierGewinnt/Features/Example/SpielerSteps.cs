using NUnit.Framework;
using TechTalk.SpecFlow;
using VierGewinnt.Model;

namespace VierGewinnt.Features.Example

{
    [Binding]
    public class SpielerSteps
    {
        
        private Spieler spieler = new Spieler();

        [Given(@"I have entered 4 into the x-position(spalte) setter")]
        public void GivenIHaveEnteredPosition(int posX)
        {
            spieler.setSpielsteinPos();
        }

        [Given(@"I have set the name of the player who is true")]
        public void IHaveSetTheNameOfThePlayerWhoIsTrue(SpielerSteps spieler)
        {
            if(spieler.spieler1 == true)
            {
                spieler.getNameP1();
            }
            if (spieler.spieler2 == true)
            {
                spieler.getNameP2();
            }
        }

        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            spieler = spieler.switchPlayer();
        }

        [Then(@"the players should switch")]
        public void ThePlayersShouldBeSwitched(int expectedResult)
        {
            
        }
    }
}
