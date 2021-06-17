using System;
using TestConsole.DSA;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //string inputString = "abc";
            //Console.WriteLine(new ArraysAndStrings().IsUnique(inputString));

            SinglyLinkedList<int> linkedList = new SinglyLinkedList<int>();

            Node<int> node1 = new Node<int>(5);
            Node<int> node2 = new Node<int>(5,node1);
            Node<int> node3 = new Node<int>(2, node2);
            Node<int> node4 = new Node<int>(3, node3);
            Node<int> node5 = new Node<int>(9, node4);
            Node<int> node6 = new Node<int>(2, node5);
            Node<int> node7 = new Node<int>(1, node6);
            Node<int> node8 = new Node<int>(9, node7);
            Node<int> node9 = new Node<int>(9, node8);

            linkedList.Head = node9;

            //SinglyLinkedList<int>.PrintLinkedList(node9);

            new LinkedLists<int>().RemoveDuplicates(linkedList.Head);
            SinglyLinkedList<int>.PrintLinkedList(linkedList.Head);
        }
    }
}
