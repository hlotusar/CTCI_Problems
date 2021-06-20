using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.DSA
{
    public class Stackk<T>
    {
        private Node Top { get; set; }

        private class Node
        {
            public T Data { get; set; }
            public Node Next { get; set; }

            public Node(T data, Node next=null )
            {
                this.Data = data; this.Next = next;
            }

            public Node()
            {
                    
            }
        }

        #region Methods

        /// <summary>
        /// checks if the stack is empty
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return Top == null;
        }


        /// <summary>
        /// inserts new element to stack
        /// </summary>
        /// <param name="data"></param>
        public void Push(T data)
        {
            Top = new Node(data, Top);
        }


        /// <summary>
        /// check the top element of the stack
        /// </summary>
        /// <returns></returns>
        public T Peek()
        {
            if (!IsEmpty())
                return Top.Data;
            throw new InvalidOperationException("no element in stack");
        }

        public T Pop()
        {
            if(!IsEmpty())
            {
                T data = Top.Data;
                Top = Top.Next;
                return data;
            }

            throw new InvalidOperationException("no element in stack");
        }
        #endregion
    }
}
