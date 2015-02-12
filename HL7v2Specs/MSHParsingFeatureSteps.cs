using System;
using HL7v2;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace HL7v2Specs
{
   [Binding]
   public class MSHParsingFeatureSteps
   {
      private MshSegmentInterpreter _mshSegmentInterpreter;

      [Given(@"A message starting with (.*)")]
      public void GivenAnMSHSegment(string mshSegment)
      {
         _mshSegmentInterpreter = new MshSegmentInterpreter(mshSegment);
      }

      [Given(@"The message: ""(.*)""")]
      public void GivenTheMessage(string hl7)
      {
         _mshSegmentInterpreter = MshSegmentInterpreter.Parse(hl7);
      }

      [Then(@"Should be interpreted as (.*)")]
      public void ThenShouldBeInterpretedAs(string expectedMshSegment)
      {
         char fieldSeperator = expectedMshSegment[3];
         char componentSeperator = expectedMshSegment[4];
         char fieldRepeat = expectedMshSegment[5];
         char escape = expectedMshSegment[6];
         char subcomponentSeparator = expectedMshSegment[7];
         AssertAreEqual(fieldSeperator, _mshSegmentInterpreter.FieldSeparator, "fieldSeperator");
         AssertAreEqual(componentSeperator, _mshSegmentInterpreter.ComponentSeparator, "ComponentSeperator");
         AssertAreEqual(fieldRepeat, _mshSegmentInterpreter.FieldRepeat, "FieldRepeat");
         AssertAreEqual(escape, _mshSegmentInterpreter.EscapeCharacter, "EscapeCharacter");
         AssertAreEqual(subcomponentSeparator, _mshSegmentInterpreter.SubcomponentSeparator, "SubcomponentSeparator");
      }

      [Then(@"Should be (invalid|valid) because (.*)")]
      public void ThenShouldMatchValidity(string validity, string message)
      {
         Assert.AreEqual(validity, _mshSegmentInterpreter.IsValid ? "valid" : "invalid", message);
      }

      [Then(@"An exception should be thrown with message: (.*)")]
      public void ThenAnExceptionShouldBeThrownWithMessageFINIsTerrible(string msg)
      {
         throw new Exception(msg);
      }

      private void AssertAreEqual(char expected, char actual, string name)
      {
         Assert.AreEqual(expected.ToString(), actual.ToString(), name);
      }
   }
}
