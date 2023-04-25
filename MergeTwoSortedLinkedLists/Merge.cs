using System;

namespace MergeTwoSortedLists
{
    internal class Merge
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {

            if (list1 == null) return list2;
            if (list2 == null) return list1;
            ListNode current1 = list1;
            ListNode current2 = list2;
            ListNode returnedHead;
            if (list1.value < list2.value)
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
                if (current1.value <= current2.value)
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
        public void PrintList(ListNode Node)
        {
            while (Node != null)
            {
                Console.Write(Node.value + " ");
                Node = Node.next;
            }
        }
    }
}