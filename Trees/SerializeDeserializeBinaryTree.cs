//Link to Leetcode Problem: https://leetcode.com/problems/serialize-and-deserialize-binary-tree/description/

public class Codec {
    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null){
            return "";
        }
        StringBuilder sb = new StringBuilder();
        helper(sb, root);
        return sb.ToString();
    }

    // Serializes the tree using pre-order traversal
    public void helper(StringBuilder sb, TreeNode root){
        if(root == null){
            sb.Append("#,"); // Use "#" to represent null node
            return;
        }
        // Store the value of the current node followed by a comma ","
        sb.Append(root.val);
        sb.Append(",");
        // Recursive call to traverse left subtree
        helper(sb, root.left);
        // Recursive call to traverse right subtree
        helper(sb, root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
        LinkedList<string> strList = new LinkedList<string>(data.Split(","));
        return buildTree(strList);
    }

    // Builds the tree from the serialized string
    public TreeNode buildTree(LinkedList<string> strList){
        if (strList.Count == 0) {
            return null;
        }
        string first = strList.First.Value;
        strList.RemoveFirst();

        if(first == "#" || string.IsNullOrEmpty(first)){
            return null;
        }
        // Parse the string value to an integer and create a new node
        TreeNode node = new TreeNode(int.Parse(first));
        // Recursively build left and right subtrees
        node.left = buildTree(strList);
        node.right = buildTree(strList);
        return node;
    }
}
