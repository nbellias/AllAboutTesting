using AllAboutTesting.MyClassLibrary;
using System;
using TechTalk.SpecFlow;

namespace AllAboutTesting.SpecFlowTests.StepDefinitions
{
    [Binding]
    public class SquareStepDefinitions
    {
        private double _side;
        private double _area;

        [Given(@"side of square is (.*)")]
        public void GivenSideOfSquareIs(double side)
        {
            _side = side;
        }

        [When(@"we want to find its area")]
        public void WhenWeWantToFindItsArea()
        {
            _area = Math.Pow(_side, 2);
        }
        [Then("the square area should be (.*)")]
        public void ThenTheSquareAreaShouldBe(int area)
        {
            //TODO: implement assert (verification) logic

            // throw new PendingStepException();
            _area.Should().Be(new Square(_side).Area());
        }
    }
}
