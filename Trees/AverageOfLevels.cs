//Link to Leetcode Problem: https://leetcode.com/problems/average-of-levels-in-binary-tree/


public IList<double> AverageOfLevels(TreeNode root) {
    List<double> result = new List<double>(); // List to store the average values of levels
    if (root == null) return result; // If the tree is empty, return an empty result list

    Queue<TreeNode> queue = new Queue<TreeNode>(); // Queue to perform level-order traversal
    queue.Enqueue(root); // Enqueue the root node to start traversal

    while (queue.Count > 0) {
        int size = queue.Count; // Get the number of nodes at the current level
        double sum = 0; // Variable to store the sum of node values at the current level
        int count = 0; // Variable to store the count of nodes at the current level

        // Traverse through all nodes at the current level
        for (int i = 0; i < size; i++) {
            TreeNode node = queue.Dequeue(); // Dequeue the node from the front of the queue
            sum += node.val; // Add the node's value to the sum
            count++; // Increment the count of nodes at the current level

            // Enqueue the left and right children of the current node if they exist
            if (node.left != null) {
                queue.Enqueue(node.left);
            }
            if (node.right != null) {
                queue.Enqueue(node.right);
            }
        }
        
        // Calculate the average value of nodes at the current level and add it to the result list
        result.Add((sum * 1.0) / count);
    }
    return result; // Return the list containing average values of levels
}
