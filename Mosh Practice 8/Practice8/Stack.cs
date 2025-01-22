using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice9
{
    public class Stack
    {
        private List<object> _stack = new List<object>();
        public void Push(object Obj)
        {
            if (Obj == null) throw new InvalidOperationException("The Entry was not valid!");

            _stack.Add(Obj);
        }

        public object Pop()
        {
            var result = _stack[_stack.Count - 1];
            _stack.RemoveAt(_stack.Count-1);
            return result;
        }

        public void Clear()
        {
            _stack.Clear();
            Console.WriteLine("Stack has been cleared!");
        }
    }
}
