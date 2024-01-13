/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        // Create a dummy node as the starting point.
        // This helps us avoids any edge cases where list1 and list2 are both empty.
        var head = new ListNode();

        // Create a pointer to keep track of the current node. This will represent the tail (end) of the merged list.
        var tail = head;

        // Traverse both lists until we reach an empty node in both lists.
        while (list1 != null && list2 != null)
        {
            // If the value of list1 is less than the value of list2, set the list1 node as the current node.
            // Move the pointer of list1 to the next node.
            if (list1.val < list2.val)
            {
                tail.next = list1;
                list1 = list1.next;
            }
            // Otherwise, set list2 as the current node.
            // Move the pointer of list2 to the next node.
            else
            {
                tail.next = list2;
                list2 = list2.next;
            }

            // Move the tail pointer so that we can add a new node.
            tail = tail.next;
        }

        // After traversing both lists, either zero or one node will be left in list1 or list2.
        // Identify which node is remaining if any and attach it to tail.
        if (list1 != null)
        {
            tail.next = list1;
        }
        else if (list2 != null)
        {
            tail.next = list2;
        }

        // Return the merged list starting from the node immediately after the head pointer.
        return head.next;
    }
}
