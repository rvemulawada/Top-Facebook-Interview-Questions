//Link to Leetcode Problem: https://leetcode.com/problems/merge-two-sorted-lists/

public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
    // Create a dummy node to serve as the starting point of the merged list
    ListNode dummy = new ListNode(0);
    ListNode curr = dummy; // Initialize a pointer to the dummy node

    // Traverse both lists while comparing their elements
    while (list1 != null && list2 != null) {
        // Compare values from both lists, and connect the smaller value to the merged list
        if (list1.val <= list2.val) {
            curr.next = list1;
            list1 = list1.next; // Move to the next node in list1
        } else {
            curr.next = list2;
            list2 = list2.next; // Move to the next node in list2
        }
        curr = curr.next; // Move the pointer of the merged list to the last added node
    }

    // If any list has remaining elements, append them to the merged list
    if (list1 == null) {
        curr.next = list2; // Append remaining nodes from list2 to the merged list
    }
    if (list2 == null) {
        curr.next = list1; // Append remaining nodes from list1 to the merged list
    }

    // Return the merged list (starting from the node after the dummy node)
    return dummy.next;
}
