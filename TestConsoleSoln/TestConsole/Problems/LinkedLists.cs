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
    }
}
