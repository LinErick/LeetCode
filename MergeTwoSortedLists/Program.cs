using System;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode list1 = new(1, null);
            ListNode list2 = new(2, null);
            /*ListNode Test = new();
            ListNode Node = Test;
            Node.next = list1;
            Node = Node.next;
            Node.next = list2;*/

            MergeTwoLists(null, null);
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode result = new();
            ListNode count= result;

            while (l1 != null && l2 != null)
            {

                if (l1.val > l2.val)
                {
                    count.next = l2;
                    l2 = l2.next;
                }
                else
                {
                    count.next = l1;
                    l1 = l1.next;
                }
                count = count.next;
            }

            if (l1 != null)
            {
                count.next = l1;
            }
            else
            {
                count.next = l2;
            }

            return result.next;
        }
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

}
