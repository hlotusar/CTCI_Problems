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
    }
}
