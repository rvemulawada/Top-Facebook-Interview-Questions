//Link to LeetCode Problem: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-tree/


  public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(root == null || root == p || root == q){
            return root;
        }
        TreeNode left = LowestCommonAncestor(root.left, p, q);
        TreeNode right = LowestCommonAncestor(root.right, p, q);

        if(left == null && right == null){
            return null;
        }
        if(left != null && right != null){
            return root;
        }
        return left == null? right: left;
    }
