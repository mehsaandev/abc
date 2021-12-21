using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VivaProject
{
    
    internal class Stack<T>
    {
        private int top;
        private List<T> Arr;
        public Stack()
        {
            Arr = new List<T>();
            top = -1;

        }
        public void Push(T n)
        {
            Arr.Add(n);
            top++;
        }
        public T Pop()
        {

            return Arr[top];
        }

    }
}
