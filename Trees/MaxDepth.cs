//Link to Leetcode Problem: https://leetcode.com/problems/maximum-depth-of-binary-tree/description/

public int MaxDepth(TreeNode root) {
    if (root == null) return 0;

    Queue<TreeNode> queue = new Queue<TreeNode>();
    queue.Enqueue(root);
    int maxDepth = 0;

    while (queue.Count > 0) {
        int levelSize = queue.Count;

        for (int i = 0; i < levelSize; i++) {
            TreeNode node = queue.Dequeue();

            if (node.left != null) {
                queue.Enqueue(node.left);
            }

            if (node.right != null) {
                queue.Enqueue(node.right);
            }
        }

        maxDepth++;
    }

    return maxDepth;
}
