//Link to Leetcode Problem : https://leetcode.com/problems/serialize-and-deserialize-binary-tree/description/

    // Encodes a tree to a single string.
    public string serialize(TreeNode root) {
        if(root == null){
            return "";
        }
        StringBuilder sb = new StringBuilder();
        serializationHelper(sb, root);
        return sb.ToString();
    }

    public void serializationHelper(StringBuilder sb, TreeNode root){
        if(root == null){
            sb.Append("#,");
            return;
        }
        //pre-order traversal
        sb.Append(root.val);
        sb.Append(",");
        serializationHelper(sb, root.left);
        serializationHelper(sb, root.right);
    }

    // Decodes your encoded data to tree.
    public TreeNode deserialize(string data) {
    LinkedList<string> strList = new LinkedList<string>(data.Split(","));
    return buildTree(strList);
    }

    public TreeNode buildTree(LinkedList<string> strList){
        if (strList.Count == 0) {
            return null;
        }
        string first = strList.First.Value;
        strList.RemoveFirst();

        if(first == "#" || string.IsNullOrEmpty(first)){
            return null;
        }
        TreeNode node = new TreeNode(int.Parse(first));
        node.left = buildTree(strList);
        node.right = buildTree(strList);
        return node;
    }
