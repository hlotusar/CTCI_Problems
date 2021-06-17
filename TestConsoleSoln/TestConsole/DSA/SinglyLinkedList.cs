using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.DSA
{
    public class SinglyLinkedList<T>
    {
        //public int Count { get; set; }

        public Node<T> Head { get; set; }
        
        public Node<T> AddNodeAtHead(Node<T> node)
        {
            if(Head != null)
            {
                node.Next = this.Head;
            }
            Head = node;
           // Count++;
            return Head;
        }

        public static void PrintLinkedList(Node<T> head)
        {
            if(head == null)
            {
                Console.WriteLine("null");
                return;
            }
            var node = head;
            while(node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public Node<T> RemoveNodeAtHead(Node<T> node)
        {
            if (Head != null)
            {
                Head = Head.Next;
                //Count--;
            }
            return Head;
        }
    }

    public class Node<T>
    {
        public T Data { get; set; }

        public Node<T> Next { get; set; }

        public Node(T data, Node<T> next = null)
        {
            Data = data; Next = next;
        }
    }
}
