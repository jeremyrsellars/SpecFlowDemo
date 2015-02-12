using System.Collections.Generic;

namespace HL7v2
{
   public sealed class MshSegmentInterpreter
   {
      public readonly char ComponentSeparator = '^';
      public readonly char FieldRepeat = '~';
      public readonly char EscapeCharacter = '\\';
      public readonly char SubcomponentSeparator = '&';
      public readonly char FieldSeparator = '|';

      public MshSegmentInterpreter(string mshSegment)
      {
         if (mshSegment.Length > 3 && mshSegment.StartsWith("MSH"))
         {
            char fieldSeparator = mshSegment[3];
            var nextSeparator = mshSegment.IndexOfAny(new[] {'\r', fieldSeparator}, 4);
            var endOfMsh2 = nextSeparator >= 0 ? nextSeparator : mshSegment.Length;
            var msh2 = mshSegment.Substring(4, endOfMsh2 - 4);
            FieldSeparator = fieldSeparator;
            if (msh2.Length > 0)
               ComponentSeparator = msh2[0];
            if (msh2.Length > 1)
               FieldRepeat = msh2[1];
            if (msh2.Length > 2)
               EscapeCharacter = msh2[2];
            if (msh2.Length > 3)
               SubcomponentSeparator = msh2[3];
         }
         IsValid = CheckIsValid();
      }

      public bool IsValid { get; private set; }

      public bool CheckIsValid()
      {
         var usedChars = new HashSet<char>();
         return
            usedChars.Add(ComponentSeparator) &&
            usedChars.Add(FieldRepeat) &&
            usedChars.Add(EscapeCharacter) &&
            usedChars.Add(SubcomponentSeparator) &&
            usedChars.Add(FieldSeparator);
      }

      public static MshSegmentInterpreter Parse(string hl7)
      {
         if (hl7.StartsWith("MSH"))
            return new MshSegmentInterpreter(hl7);
         return new MshSegmentInterpreter("");
      }
   }
}