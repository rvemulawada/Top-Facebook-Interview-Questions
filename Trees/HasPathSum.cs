//Link to Leetcode Problem: https://leetcode.com/problems/path-sum/

    public bool HasPathSum(TreeNode root, int targetSum) {
        if(root == null){
            return false;
        }

        if(root.right == null && root.left == null && targetSum-root.val == 0){
            return true;
        }
        return HasPathSum(root.left, targetSum-root.val) || HasPathSum(root.right, targetSum - root.val);
    }
