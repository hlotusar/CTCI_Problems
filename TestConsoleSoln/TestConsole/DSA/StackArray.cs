using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.DSA
{
    public class StackArray<T>
    {
        //make a dynamic array and always copy the objects to that

        private List<T> stack = new List<T>();

        private int Top { get { return stack.Count; } }

        public void Push(T data)
        {
            stack.Add(data);
        }

        public bool IsEmpty()
        {
            return Top < 1;
        }
        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException();
            return stack[Top - 1];
        }

        public T Pull()
        {
            if (IsEmpty())
                throw new InvalidOperationException();
            T data = stack[Top - 1];
            stack.RemoveAt(Top - 1);
            return data;
        }
    }
}
