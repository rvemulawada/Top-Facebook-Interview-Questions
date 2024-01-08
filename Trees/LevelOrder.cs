//Link to Leetcode Problem: https://leetcode.com/problems/binary-tree-level-order-traversal/description/

 public IList<IList<int>> LevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) return result;

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            int size = q.Count;
            List<int> currLevelNodes = new List<int>();
            for(int i=0; i< size; i++){
                TreeNode node = q.Dequeue();
                currLevelNodes.Add(node.val);
                if(node.left != null){
                    q.Enqueue(node.left);
                }
                if(node.right != null){
                    q.Enqueue(node.right);
                }
            }
            result.Add(currLevelNodes);
        }
        return result;
    }
