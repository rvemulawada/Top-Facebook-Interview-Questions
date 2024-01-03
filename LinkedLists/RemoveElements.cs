//Link to Leetcode problem: https://leetcode.com/problems/remove-linked-list-elements/

public ListNode RemoveElements(ListNode head, int val) {
    // If the linked list is empty, return the head (null in this case)
    if (head == null) 
        return head;

    ListNode curr = head; // Start from the head of the linked list

    // Traverse the linked list to remove nodes with the given value
    while (curr.next != null) {
        // If the value of the next node is equal to the target value 'val'
        if (curr.next.val == val) {
            curr.next = curr.next.next; // Skip the node by adjusting pointers
        } else {
            curr = curr.next; // Move to the next node
        }
    }

    // Check if the head node has the target value
    // If so, return the next node as the new head, otherwise, return the original head
    return head.val == val ? head.next : head;
}
