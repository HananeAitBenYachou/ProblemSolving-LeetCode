using System;

namespace ProblemSolving_LeetCode
{
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

    internal class Program
    {
        public static int GetDecimalValue_Approach1(ListNode head)
        {
            int result = 0;
            while (head != null) 
            {
                result = result * 2 + head.val; 
                head = head.next;
            }
           
            return result;
        }

        public static int GetDecimalValue_Approach2(ListNode head)
        {
            int result = 0;
            while (head != null)
            {
                result = (result << 1) | head.val;
                head = head.next;
            }

            return result;
        }

        static void Main(string[] args)
        {
            ListNode node1 = new ListNode();
            ListNode node2 = new ListNode();
            ListNode node3 = new ListNode();

            node1.val = 1;
            node2.val = 0;
            node3.val = 1;

            node1.next = node2;
            node2.next = node3;
            node3.next = null;

            ListNode head = new ListNode();
            head = node1;

            Console.WriteLine(GetDecimalValue_Approach2(head));

            Console.ReadKey();
        }
    }
}
