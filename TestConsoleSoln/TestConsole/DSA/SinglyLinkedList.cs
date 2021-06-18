using System;
using System.Collections.Generic;
using System.Text;

namespace TestConsole.DSA
{
    public class SinglyLinkedList<T>
    {
        //public int Count { get; set; }

        public static Node<T> Head { get; set; }


        public static Node<T> AddNodeAtHead(T value, Node<T> headNode)
        {
            return new Node<T>(value, headNode);
        }

        public static Node<T> ReverseALinkedList(Node<T> head)
        {
            if (head == null || head.Next == null)
                return head;
            var node = head.Next;
            Node<T> reverseLinkedList = new Node<T>(head.Data);
            while (node != null)
            {
                reverseLinkedList = AddNodeAtHead(node.Data, reverseLinkedList);
                node = node.Next;
            }
            return reverseLinkedList;
        }

        public static void PrintLinkedList(Node<T> head)
        {
            if (head == null)
            {
                Console.WriteLine("null");
                return;
            }
            var node = head;
            while (node != null)
            {
                Console.WriteLine(node.Data);
                node = node.Next;
            }
        }

        public static Node<T> RemoveNodeAtHead(Node<T> node)
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
