namespace Leetcode;

public class DeleteNodesFromLinkedListPresentinArray : ILeetcodeSolution
{
    public void Run()
    {
    }
    
    public class Solution {
        public ListNode<int> ModifiedList(int[] nums, ListNode<int> head) {
            bool[] deleteNum = new bool[100001];
            foreach (int i in nums){
                deleteNum[i] = true;
            }

            ListNode<int>? currentNode = null;
            ListNode<int>? previousNode = head;
            ListNode<int>? nextNode = head;

            while (nextNode != null) {
                previousNode = currentNode;
                currentNode = nextNode;
                nextNode = currentNode.next;
                if (deleteNum[currentNode.val])
                {
                    if (head == currentNode)
                    {
                        head = nextNode;
                    }
                    else
                    {
                        previousNode.next = nextNode;
                        currentNode = previousNode;
                    }
                }
            }

            return head;
        }
    }
}