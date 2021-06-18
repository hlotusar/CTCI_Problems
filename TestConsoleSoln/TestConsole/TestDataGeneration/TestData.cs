using System;
using System.Collections.Generic;
using System.Text;
using TestConsole.DSA;

namespace TestConsole.TestDataGeneration
{
    public class TestData
    {
        public static Node<int> CreateUnSortedIntegerLinkedList(int listNumber=3)
        {
            Random random = new Random();
            Node<int> headNode=new Node<int>(2);
            var bnode = headNode;
            for(int i=1; i<listNumber; i++)
            {
                bnode.Next = new Node<int>(random.Next(10));
                bnode = bnode.Next;
            }
            return headNode;
        }

        public static Node<int> CreateSortedIntegerLinkedList(int nodeNumber = 3,int startValue = 1, bool ascending = true)
        { 
            Node<int> headNode = new Node<int>(startValue);
            var bnode = headNode;
            for (int i = 1; i < nodeNumber; i++)
            {
                if(ascending)
                    bnode.Next = new Node<int>(++startValue);
                else bnode.Next = new Node<int>(--startValue);

                bnode = bnode.Next;
            }
            return headNode;
        }

    }
}
