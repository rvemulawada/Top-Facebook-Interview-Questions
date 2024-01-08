//Link to Leetcode Problem: https://leetcode.com/problems/validate-binary-search-tree/description/

    public bool IsValidBST(TreeNode root) {
        return ValidateBST(root, long.MinValue, long.MaxValue);
    }

    public bool ValidateBST(TreeNode root, long min, long max)
    {
        if (root == null) return true; 
        if (root.val <= min || root.val >= max) return false; 
        return ValidateBST(root.left, min, root.val) && ValidateBST(root.right, root.val, max);
    }
