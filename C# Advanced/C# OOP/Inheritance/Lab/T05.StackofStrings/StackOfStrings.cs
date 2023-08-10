using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
    
namespace CustomStack
{
    public class StackOfStrings:Stack<string>
    {
        Stack<string> stack = new();
        public bool IsEmpty()
        {
            return stack.Any();
        }
        public Stack<string> AddRange(List<string> coll)
        {
            foreach (var item in coll)
            {
                stack.Push(item);
            }
            return stack;
        }
    }
}
