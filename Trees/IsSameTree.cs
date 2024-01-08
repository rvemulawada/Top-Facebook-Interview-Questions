//Link to Leetcode Problem: https://leetcode.com/problems/same-tree/


public bool IsSameTree(TreeNode p, TreeNode q) {
    Stack<TreeNode> stackP = new Stack<TreeNode>();
    Stack<TreeNode> stackQ = new Stack<TreeNode>();

    if (p != null) stackP.Push(p);
    if (q != null) stackQ.Push(q);

    while (stackP.Count > 0 && stackQ.Count > 0) {
        TreeNode nodeP = stackP.Pop();
        TreeNode nodeQ = stackQ.Pop();

        if (nodeP.val != nodeQ.val) {
            return false;
        }

        if (nodeP.left != null) stackP.Push(nodeP.left);
        if (nodeQ.left != null) stackQ.Push(nodeQ.left);

        if (stackP.Count != stackQ.Count) {
            return false; // If the tree structures are different
        }

        if (nodeP.right != null) stackP.Push(nodeP.right);
        if (nodeQ.right != null) stackQ.Push(nodeQ.right);
    }

    return stackP.Count == stackQ.Count;
}
