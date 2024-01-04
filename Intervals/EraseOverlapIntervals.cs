//Link to Leetcode Problems: https://leetcode.com/problems/non-overlapping-intervals/description/

    public int EraseOverlapIntervals(int[][] intervals) {
        Array.Sort(intervals, (x, y) => x[0].CompareTo(y[0]));
        int minIntervals = 0;
        int[] curr = intervals[0];

        for(int i=1; i< intervals.Length; i++){
            if(curr[1] > intervals[i][0]){
                minIntervals++;
                if(curr[1] > intervals[i][1]){
                    curr = intervals[i];
                }
            }else{
                curr = intervals[i];
            }
        }
        return minIntervals;
    }
