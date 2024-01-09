//Link to Leetcode : https://leetcode.com/problems/sum-root-to-leaf-numbers/description/

public int SumNumbers(TreeNode root) {
        if(root == null){
            return 0;
        }
        return helper(root, 0);
    }

    public int helper(TreeNode node, int currentSum){
        if(node == null){
            return 0;
        }

        currentSum = currentSum * 10 + node.val;
        if(node.left == null && node.right == null){
            return currentSum;
        }
       
        int left = helper(node.left, currentSum);
        int right = helper(node.right, currentSum);
        return left + right;
    }
