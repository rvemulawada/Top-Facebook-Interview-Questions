//Link to Leetcode Problem: https://leetcode.com/problems/invert-binary-tree/description/

public TreeNode InvertTree(TreeNode root) {
        if(root == null) { return root;}

        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            TreeNode node = queue.Dequeue();
            TreeNode left = node.left;
            node.left = node.right;
            node.right = left;

            if(node.left != null){
                queue.Enqueue(node.left);
            }

            if(node.right != null){
                queue.Enqueue(node.right);
            }
        }
        return root;
    }
