namespace Leetcode;

// Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode? next;
    public ListNode(int val=0, ListNode? next=null) {
        this.val = val;
        this.next = next;
    }
    
    public static ListNode GenerateLinkedList(int[] headInts)
    {
        ListNode[] head = new ListNode[headInts.Length];
        for (int i = 0; i < headInts.Length; i++)
        {
            head[i] = new ListNode(headInts[i]);
        }
        for (int i = 0; i < head.Length-1; i++)
        {
            head[i].next = head[i + 1];
        }

        return head[0];
    }

    public static void PrintArray(ListNode[] array)
    {
        foreach (var listNode in array)
        {
            ListNode[] subArray = GetListNodes(listNode);
            foreach (var node in subArray)
            {
                Console.Write("{0}, ", node);
            }
            Console.Write("|");
        }

        Console.WriteLine();
    }

    public static ListNode[] GetListNodes(ListNode head)
    {
        List<ListNode> list = new List<ListNode>();
        while (head != null)
        {
            list.Add(head);
            head = head.next;
        }

        return list.ToArray();
    }

    public override string ToString()
    {
        return val.ToString();
    }
}