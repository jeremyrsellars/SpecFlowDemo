using System.Windows.Forms;
using HL7v2Diagnostic;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HL7v2Specs
{
   [Binding]
   public class WinformsMSHParsingFeatureSteps
   {
      private Form1 ui;

      [Given(@"A message starting with (.*)")]
      public void GivenAnMSHSegment(string mshSegment)
      {
         ui = new Form1{Message = mshSegment};
      }

      [Given(@"The message: ""(.*)""")]
      public void GivenTheMessage(string hl7)
      {
         ui = new Form1 { Message = hl7 };
      }

      [Then(@"Should be interpreted as (.*)")]
      public void ThenShouldBeInterpretedAs(string expectedMshSegment)
      {
         char fieldSeperator = expectedMshSegment[3];
         char componentSeperator = expectedMshSegment[4];
         char fieldRepeat = expectedMshSegment[5];
         char escape = expectedMshSegment[6];
         char subcomponentSeparator = expectedMshSegment[7];
         AssertAreEqual(fieldSeperator, ui.txtField.Text, "FieldSeperator");
         AssertAreEqual(componentSeperator, ui.txtComponent.Text, "ComponentSeperator");
         AssertAreEqual(fieldRepeat, ui.txtFieldRepeat.Text, "FieldRepeat");
         AssertAreEqual(escape, ui.txtEscape.Text, "EscapeCharacter");
         AssertAreEqual(subcomponentSeparator, ui.txtSubComponent.Text, "SubcomponentSeparator");
      }

      [Then(@"Should be (invalid|valid) because (.*)")]
      public void ThenShouldMatchValidity(string validity, string message)
      {
         Assert.AreEqual(validity, ui.chkValid.CheckState == CheckState.Checked ? "valid" : "invalid", message);
      }

      private void AssertAreEqual(char expected, string actual, string name)
      {
         Assert.AreEqual(expected.ToString(), actual.ToString(), name);
      }
   }
}
