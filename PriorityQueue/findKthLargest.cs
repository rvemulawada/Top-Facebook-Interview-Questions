//Link to Leetcode Problem:https://leetcode.com/problems/kth-largest-element-in-an-array/description/

    //Java
    public int findKthLargest(int[] nums, int k) {
        var pq = new PriorityQueue<Integer>();
       for(var n : nums){
           pq.offer(n);
           if(pq.size() > k){
               pq.poll();
           }
       }
        return pq.peek(); 
    }
