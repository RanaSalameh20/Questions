using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeTwoSortedLists
{
    class Program : Merge
    {
        static void Main(string[] args)
        {
            ListNode node1 = new ListNode(1);
            node1.next = new ListNode(2);
            node1.next.next = new ListNode(4);
            

            ListNode node2 = new ListNode(1);
            node2.next = new ListNode(3);
            node2.next.next = new ListNode(4);

            Merge merge = new Merge();

            ListNode result = merge.MergeTwoLists(node1, node2);
            Console.WriteLine("merged lists:");
            merge.PrintList(result);
 
        }
    }
}



