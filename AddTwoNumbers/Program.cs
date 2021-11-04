using System;

namespace AddTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            ListNode node1 = new()
            { 
                
            };
        }
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode CountData = new(0);
            ListNode resultData = CountData;
            
            int sum = 0;

            while (l1 != null || l2 != null || sum > 0)
            {
                if (l1 != null)
                    sum += l1.val;

                if(l2!=null)
                    sum += l1.val;

                CountData.next = new ListNode(sum % 10);
                CountData = CountData.next;

                sum /= 10;
                l1 = l1.next;
                l2 = l2.next;
            }

            return resultData.next;
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
