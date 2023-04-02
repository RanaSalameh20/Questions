using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //case 1
            // list1  = [1,2,4]
            //list2 = [1,3,4]

            ListNode res = null;
            ListNode a = new ListNode(1);
            a.next = new ListNode(2);
            a.next.next = new ListNode(4);
            //a.next.next.next = new ListNode(40);

            ListNode b = new ListNode(1);
            b.next = new ListNode(3);
            b.next.next = new ListNode(4);

            res = MergeTwoLists(a, b);

            Console.WriteLine("merged lists:");
            printList(res);

            //=====================================================================
            //case2
            // list1  = []
            //list2 = []
            //ListNode res = null;
            //ListNode a = null;
            //ListNode b = null;
            //res = MergeTwoLists(a, b);
            //=====================================================================

            //case3
            // list1  = []
            //list2 = [0]
            //ListNode res = null;
            //ListNode a = null;
            //ListNode b = new ListNode(0);
            
            //res = MergeTwoLists(a, b);
            //Console.WriteLine("Merged Lists:");
            //printList(res);
        }
        public static ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null) return list2;
            if (list2 == null) return list1;
            ListNode current1 = list1, current2 = list2;
            ListNode returnedHead;
            if (list1.val < list2.val)
            {
                returnedHead = list1;
                current1 = list1.next;
            }
            else
            {
                returnedHead = list2;
                current2 = list2.next;
            }

            ListNode tail = returnedHead;
            while (current1 != null && current2 != null)
            {
                if (current1.val <= current2.val)
                {
                    tail.next = current1;
                    current1 = current1.next;
                }
                else
                {
                    tail.next = current2;
                    current2 = current2.next;
                }
                tail = tail.next;
            }

            if (current1 != null)
                tail.next = current1;
            else
                tail.next = current2;

            return returnedHead;
        }
        static void printList(ListNode Node)
        {
            while (Node != null)
            {
                Console.Write(Node.val + " ");
                Node = Node.next;
            }
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



