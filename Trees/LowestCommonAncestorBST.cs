//Link to Leetcode Problem: https://leetcode.com/problems/lowest-common-ancestor-of-a-binary-search-tree/description/

    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        if(p.val > root.val && q.val > root.val){
            return LowestCommonAncestor(root.right, p, q);
        }
        else if(p.val < root.val && q.val < root.val){
            return LowestCommonAncestor(root.left, p, q);
        }
        else{
            return root;
        }
    }
