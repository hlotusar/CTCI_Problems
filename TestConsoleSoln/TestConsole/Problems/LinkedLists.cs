using TestConsole.DSA;

namespace TestConsole
{
    public class LinkedLists<T>
    {
        /// <summary>
        /// 2.1 - Remove duplicates from a unsorted singly linked list
        /// Bruteforce by taking buffer - O(N^2)
        /// </summary>
        /// <param name="Head"></param>
        /// <returns></returns>
        public void RemoveDuplicates(Node<T> Head)
        {
            var node = Head;
            while(node!=null)
            {
                var bufferNode = node;
                while(bufferNode.Next != null)
                {
                    if (node.Data.Equals(bufferNode.Next.Data))
                    {
                        bufferNode.Next = bufferNode.Next.Next;
                    }
                    else bufferNode = bufferNode.Next;
                }
                node = node.Next;
            }
        }


        /// <summary>
        /// 2.2 - return the linked list from kth element to last, the first element is 1 not zero - O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="kth"></param>
        /// <returns></returns>
        public Node<T> ReturnKthToLast(Node<T> head,int kth=1)
        {
            if (kth < 2)
                return head;
            var node = head;
            while(kth > 1 && node != null)
            {
                node = node.Next;
                kth--;
            }
            if (kth != 1)
                return null;
            else return node;

        }


        /// <summary>
        /// 2.3 - Remove the given midde node - O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="value"></param>
        public void RermoveMiddleNode(Node<T> head, T value)
        {
            if (head == null || head.Next == null)
                return;

            var prevNode = head;
            while(prevNode.Next != null)
            {
                if(prevNode.Next.Data.Equals(value) && prevNode.Next.Next != null)
                {
                    prevNode.Next = prevNode.Next.Next;
                    return;
                }
                prevNode = prevNode.Next;
            }
        }


        /// <summary>
        /// 2.4 - Make partition around a given value x, left side will be less than x 
        /// and right side will be greater than equal to x, order does not matter- O(N)
        /// </summary>
        /// <param name="head"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public Node<int> MakePartition(Node<int> head, int value)
        {
            if (head == null || head.Next == null)
                return head;
            var node = head.Next;
            Node<int> headNode = new Node<int>(head.Data);
            var tailNode = headNode;
            while(node != null)
            {
                if(node.Data < value)
                {
                    headNode = new Node<int>(node.Data,headNode);
                }
                else
                {
                    tailNode.Next = new Node<int>(node.Data);
                    tailNode = tailNode.Next;
                }
                node = node.Next;
            }
            return headNode;
        }

        /// <summary>
        /// 2.5 - sum of two linked lists where the head is 1st place and tail is 10^nth place
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public Node<int> SumListsInReverse(Node<int> node1, Node<int> node2)
        {
            if (node1 == null)
                return node2;
            if (node2 == null)
                return node1;

            Node<int> sumNode = new Node<int>((node1.Data + node2.Data) % 10);
            int carry = (node1.Data + node2.Data) / 10;
            node1 = node1.Next; node2 = node2.Next;
            var bnode = sumNode;
            while(node1 != null || node2 != null)
            {
                if(node2 != null && node1 != null)
                {
                    bnode.Next = new Node<int>((node1.Data + node2.Data + carry) % 10);
                    carry = (node1.Data + node2.Data + carry) / 10;
                    bnode = bnode.Next;
                    node1 = node1.Next;
                    node2 = node2.Next;
                }
                else
                {
                    if(node1 != null)
                    {
                        if(carry != 0)
                        {
                            bnode.Next = new Node<int>((node1.Data + carry) % 10);
                            carry = (node1.Data + carry) / 10;
                            node1 = node1.Next;
                        }
                        else { bnode.Next = node1; break; }
                        
                    }
                    if(node2 != null)
                    {
                        if (carry != 0)
                        {
                            bnode.Next = new Node<int>((node2.Data + carry) % 10);
                            carry = (node2.Data + carry) / 10;
                            node2 = node2.Next;
                        }
                        else { bnode.Next = node2; break; }
                    }
                }
            }
            if (carry != 0)
            {
                bnode.Next = new Node<int>(carry);
            }
            return sumNode;
        }


        /// <summary>
        /// sum of two linked lists where the head is 10^n place and tail is 1st place
        /// </summary>
        /// <param name="node1"></param>
        /// <param name="node2"></param>
        /// <returns></returns>
        public Node<int> SumListsInForward(Node<int> node1, Node<int> node2)
        {
            if (node1 == null)
                return node2;
            if (node2 == null)
                return node1;

            var reverseNode1 = SinglyLinkedList<int>.ReverseALinkedList(node1);
            var reverseNode2 = SinglyLinkedList<int>.ReverseALinkedList(node2);
            var reverseSum = SumListsInReverse(reverseNode1, reverseNode2);
            return SinglyLinkedList<int>.ReverseALinkedList(reverseSum);
        }
    }
}
