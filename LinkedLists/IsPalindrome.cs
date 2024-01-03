//Link to Leetcode Problem: https://leetcode.com/problems/palindrome-linked-list/description/

public class Solution {
    public bool IsPalindrome(ListNode head) {
        // Find the middle of the linked list
        ListNode middle = FindMiddle(head);
        
        // Reverse the second half of the linked list
        ListNode reversedSecondListHead = ReverseLinkedList(middle.next);
        
        ListNode p1 = head;
        ListNode p2 = reversedSecondListHead;

        // Compare the first half with the reversed second half of the linked list
        while (p2 != null) {
            if (p1.val != p2.val) {
                return false;
            }
            p1 = p1.next;
            p2 = p2.next;
        }
        return true;
    }

    // Helper function to find the middle of the linked list
    public ListNode FindMiddle(ListNode head) {
        ListNode slow = head;
        ListNode fast = head;

        while (fast.next != null && fast.next.next != null) {
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }

    // Helper function to reverse the linked list
    public ListNode ReverseLinkedList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
        return prev;
    }
}
