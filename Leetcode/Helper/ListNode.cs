namespace Leetcode;

// Definition for singly-linked list.
public class ListNode<T> {
    public T? val;
    public ListNode<T>? next;
    public ListNode(T? val, ListNode<T>? next=null) {
        this.val = val;
        this.next = next;
    }
    
    public static ListNode<T> GenerateLinkedList(T[] headInts)
    {
        ListNode<T>[] head = new ListNode<T>[headInts.Length];
        for (int i = 0; i < headInts.Length; i++)
        {
            head[i] = new ListNode<T>(headInts[i]);
        }
        for (int i = 0; i < head.Length-1; i++)
        {
            head[i].next = head[i + 1];
        }

        return head[0];
    }

    public static void PrintArray(ListNode<T>[] array)
    {
        foreach (var listNode in array)
        {
            ListNode<T>[] subArray = GetListNodes(listNode);
            foreach (var node in subArray)
            {
                Console.Write("{0}, ", node);
            }
            Console.Write("|");
        }

        Console.WriteLine();
    }

    public static ListNode<T>[] GetListNodes(ListNode<T> head)
    {
        List<ListNode<T>> list = new List<ListNode<T>>();
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