using NUnit.Framework;
using TechTalk.SpecFlow;

namespace Demo.Specs
{
   [Binding]
   public class AddingCalculatorSteps
   {
      private readonly AddingCalculator calc = new AddingCalculator();

      [Given(@"I have entered (.*) into the calculator")]
      public void GivenIHaveEnteredIntoTheCalculator(int addend)
      {
         calc.Push(addend);
      }

      [Given(@"I press add")]
      public void GivenIPressAdd()
      {
         calc.Add();
      }

      [Given(@"I press subtract")]
      public void GivenIPressSubtract()
      {
         calc.Subtract();
      }

      [When(@"I press add")]
      public void WhenIPressAdd()
      {
         calc.Add();
      }

      [Then(@"the result should be (.*) on the screen( because .*)?")]
      public void ThenTheResultShouldBeOnTheScreen(int result, string because)
      {
         Assert.AreEqual(result, calc.DisplayedValue, because);
      }
   }
}
