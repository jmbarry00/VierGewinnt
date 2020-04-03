using NUnit.Framework;
using TechTalk.SpecFlow;

namespace VierGewinnt.Features.Example

{
    [Binding]
    public class SpielfeldSteps
    {
        
        private Spielfeld feld = new Spielfeld(4,7);

        [Given(@"I have entered 4 into the x-position(spalte) setter")]
        public void GivenIHaveEnteredPosition(int posX)
        {
            spieler.setSpielsteinPos = 4;
        }

        [Given(@"I call the function FeldIstBesetzt on this position")]
        public void ICallFeldIstBesetzt(SpielerSteps spieler)
        {
            bool result = feld.feldIstBesetzt(4, 0);
        }

        [Then(@"result should be true")]
        public void ThePlayersShouldBeSwitched(int expectedResult)
        {
            result.Should().Be().True();
        }
    }
}
