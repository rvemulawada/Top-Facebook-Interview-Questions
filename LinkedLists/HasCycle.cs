//Link to Leetcode Problem: https://leetcode.com/problems/linked-list-cycle/description/

 public bool HasCycle(ListNode head) {
        if(head == null){
            return false;
        }

        ListNode slow = head, fast = head;

        while(fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;

            if(slow == fast){
                return true;
            }
        }
        return false;
    }
