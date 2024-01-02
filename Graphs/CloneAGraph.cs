//Link to Leetcode Problem: https://leetcode.com/problems/clone-graph/description/

public Node CloneGraph(Node node) {
    if(node == null) return node;
    
    // Dictionary to map original nodes to their cloned nodes
    Dictionary<Node, Node> dict = new Dictionary<Node, Node>();
    Queue<Node> queue = new Queue<Node>();

    // Clone the initial node and add it to the dictionary
    dict.Add(node, new Node(node.val));
    queue.Enqueue(node);

    while(queue.Count > 0){
        // Dequeue a node from the queue
        Node n = queue.Dequeue();
        
        // Traverse through the neighbors of the current node
        foreach(Node neighbor in n.neighbors){
            if(!dict.ContainsKey(neighbor)){
                // If the neighbor is not present in the dictionary, create a clone and add it to the dictionary
                dict.Add(neighbor, new Node(neighbor.val));
                queue.Enqueue(neighbor);
            }
            // Assign the cloned neighbor to the cloned node's neighbor list
            dict[n].neighbors.Add(dict[neighbor]);
        }
    }
    // Return the cloned node
    return dict[node];
}
