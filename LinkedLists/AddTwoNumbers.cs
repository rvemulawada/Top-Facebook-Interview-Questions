//Link to Leetcode Problem: https://leetcode.com/problems/add-two-numbers/

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummy = new ListNode(0);
        ListNode curr = dummy;

        int sum = 0, carry =0;

        while(l1 != null || l2 != null){
            sum = carry + (l1 != null? l1.val : 0) + (l2 != null? l2.val : 0);
            carry = sum >= 10? 1: 0;
            curr.next = new ListNode(sum % 10);
            curr = curr.next;
            if(l1 != null) {l1 = l1.next;}
            if(l2 != null) {l2 = l2.next; }
        }
        if(carry > 0){
            curr.next = new ListNode(carry);
        }
        return dummy.next;
    }
