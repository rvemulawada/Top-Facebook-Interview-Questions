//Link to Leetcode Problem: https://leetcode.com/problems/minimum-depth-of-binary-tree/

    public int MinDepth(TreeNode root) {
        if(root == null)
            return 0;

        int minDepth = 1;
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while(queue.Count > 0){
            int size = queue.Count;
            for(int i=0; i< size; i++){
                TreeNode node = queue.Dequeue();
                if(node.left == null && node.right == null){
                    return minDepth;
                }
                if(node.left != null){
                    queue.Enqueue(node.left);
                }
                if(node.right != null){
                    queue.Enqueue(node.right);
                }
            }
            minDepth++;
        }
        return minDepth;
    }
