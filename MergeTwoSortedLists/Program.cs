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
            MergeTwoLists(list1, list2);
        }
        public static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null && l2 == null)
                return null;

            if (l1 == null)
                return l2;

            if (l2 == null)
                return l1;

            ListNode result = new();
            ListNode count= result;

            while (l1 != null && l2 != null)
            {

                if (l1.val > l2.val)
                {
                    count.val = l2.val;
                    l2 = l2.next;
                }
                else
                {
                    count.val = l1.val;
                    l1 = l1.next;
                }
                count = count.next;
            }

            if (l1 != null)
            {
                count = l1;
            }

            if (l2 != null)
            {
                count.val= l2.val;
            }
                

            return result;
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
