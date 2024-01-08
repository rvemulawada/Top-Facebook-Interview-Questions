//Link to Leetcode Problem: https://leetcode.com/problems/binary-tree-level-order-traversal-ii/description/

    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if(root == null) {return result;}

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);

        while(q.Count > 0){
            int size = q.Count;
            List<int> currLevelNode = new List<int>();
            for(int i=0; i< size; i++){
                TreeNode node = q.Dequeue();
                currLevelNode.Add(node.val);
                if(node.left != null){
                    q.Enqueue(node.left);
                }
                if(node.right != null){
                    q.Enqueue(node.right);
                }
            }
            result.Insert(0, currLevelNode);
        }
        return result;
    }
