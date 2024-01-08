//Link to Leetcode Problem: https://leetcode.com/problems/remove-nth-node-from-end-of-list/description/

public ListNode RemoveNthFromEnd(ListNode head, int n) {
    if (head == null || n <= 0) return head;
    
    ListNode curr = head;
    int count = 0; // Initialize count to 0
    while(curr != null) {
        curr = curr.next;
        count++;
    }
    int len = count - n; // Calculate the position of the node to remove from the start

    if (len == 0) { // If the node to remove is the head
        return head.next;
    }

    ListNode prev = head;
    for (int i = 0; i < len - 1; i++) {
        prev = prev.next;
    }
    
    prev.next = prev.next.next; // Remove the node by skipping it in the linked list
    return head;
}
