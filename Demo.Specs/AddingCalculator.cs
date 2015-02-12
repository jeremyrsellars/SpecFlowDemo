using System.Collections.Generic;
using System.Linq;

namespace Demo.Specs
{
    public class AddingCalculator
    {
       readonly List<int> operands = new List<int>{};

       public void Push(int value)
       {
          operands.Add(value);
       }

       public void Add()
       {
          var result = operands.Sum();
          SetResult(result);
       }

       public void Subtract()
       {
          var result = Subtract(operands);
          SetResult(result);
       }

       private int Subtract(IEnumerable<int> operands)
       {
          return operands.FirstOrDefault() - operands.Skip(1).Sum();
       }

       public int DisplayedValue { get { return operands.LastOrDefault(); } }

       private void SetResult(int result)
       {
          operands.Clear();
          operands.Add(result);
       }
    }
}
