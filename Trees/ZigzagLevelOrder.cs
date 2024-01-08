//Link to Leetcode Problem: https://leetcode.com/problems/binary-tree-zigzag-level-order-traversal/description/

    public IList<IList<int>> ZigzagLevelOrder(TreeNode root) {
        List<IList<int>> result = new List<IList<int>>();
        if(root == null){
            return result;
        }

        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        bool leftToRight = true; 
        while(q.Count > 0){
            int size = q.Count;
            List<int> currentLevelNodes = new List<int>();
            for(int i=0; i< size; i++){
                TreeNode node = q.Dequeue();
                if(leftToRight){
                    currentLevelNodes.Add(node.val);
                }else{
                    currentLevelNodes.Insert(0, node.val);
                }

                if(node.left != null){
                    q.Enqueue(node.left);
                }
                if(node.right != null){
                    q.Enqueue(node.right);
                }    
            }
            result.Add(currentLevelNodes);
            leftToRight = !leftToRight;
        }
        return result;
    }
