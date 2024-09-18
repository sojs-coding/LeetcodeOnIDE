namespace Leetcode;

public class DeleteNodesFromLinkedListPresentinArray : ILeetcodeSolution
{
    public void Run()
    {
    }
    
 // * Definition for singly-linked list.
    public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
    this.val = val;
    this.next = next;
    }
    }
    
    public class Solution {
        public ListNode ModifiedList(int[] nums, ListNode head) {
            bool[] deleteNum = new bool[100001];
            foreach (int i in nums){
                deleteNum[i] = true;
            }

            ListNode? currentNode = null;
            ListNode? previousNode = head;
            ListNode? nextNode = head;

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