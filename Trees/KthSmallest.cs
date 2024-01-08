//Link to Leetcode Problem: https://leetcode.com/problems/kth-smallest-element-in-a-bst/description/

    public int KthSmallest(TreeNode root, int k) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        PushLeft(stack, root);
        for (int i = 1; i < k; ++i) {
            TreeNode node = stack.Pop(); // node is the i_th smallest element
            PushLeft(stack, node.right);
        }
        return stack.Pop().val;
    }

    public void PushLeft(Stack<TreeNode> stack, TreeNode root) {
        while (root != null) {
            stack.Push(root);
            root = root.left;
        }
    }
