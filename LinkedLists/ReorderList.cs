//Link to Leetcode Problem: https://leetcode.com/problems/reorder-list/

  public void ReorderList(ListNode head) {
        if(head == null){
            return;
        }

        //find middle
        ListNode slow = head, fast = head;

        while(fast.next != null && fast.next.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }

        ListNode secondHalf = slow.next;
        slow.next = null;

        //Reverse LinkedList from Middle
        ListNode prev = null;
        ListNode curr = secondHalf;
        while(curr != null){
            ListNode temp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = temp;
        }

        ListNode first = head;
        ListNode secondHalfHead = prev;

        //Alternatively connect nodes from both linkedlist
        while(secondHalfHead != null){
            ListNode tmp1 = first.next;
            ListNode tmp2 = secondHalfHead.next;

            first.next = secondHalfHead;
            secondHalfHead.next = tmp1;

            first = tmp1;
            secondHalfHead = tmp2;
        }
    }
