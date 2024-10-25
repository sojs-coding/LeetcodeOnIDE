namespace Leetcode;

public class SplitLinkedListinParts : ILeetcodeSolution
{
    public void Run()
    {
        Solution solution = new Solution();
        int[] headInts = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
        int k = 3;
        ListNode<int>.PrintArray(solution.SplitListToParts(ListNode<int>.GenerateLinkedList(headInts), k));
        
        headInts = [1, 2, 3];
        k = 5;
        ListNode<int>.PrintArray(solution.SplitListToParts(ListNode<int>.GenerateLinkedList(headInts), k));
    }
    
    public class Solution {
        public ListNode<int>[] SplitListToParts(ListNode<int> head, int k)
        {
            ListNode<int>[] array = new ListNode<int>[k];
            
            int size = 0;
            ListNode<int> temp = head;
            while (temp != null)
            {
                temp = temp.next;
                size += 1;
            }

            int minSize = size / k;
            int remainder = size - minSize * k;
            temp = new ListNode<int>(-1, head);

            for (int i = 1; i < k; i++)
            {
                int currSize = 0;
                while (currSize < minSize)
                {
                    temp = temp.next;
                    currSize += 1;
                }

                if (remainder > 0)
                {
                    temp = temp.next;
                    remainder -= 1;
                }

                array[i] = temp;
            }

            array[0] = head;

            for (int i = 1; i < array.Length; i++)
            {
                temp = array[i].next;
                array[i].next = null;
                array[i] = temp;
            }
            return array;
        }
    }
}