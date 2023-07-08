Coding Challenge: Shortest Path in a Weighted Directed Graph

Given a weighted directed graph, find the shortest path from a given source node to a destination node.

Write a function that takes the following input:

Input:
- graph (Dictionary<int, List<(int, int)>>): A weighted directed graph represented as a dictionary of nodes and their adjacent nodes with edge weights. The nodes are represented by integers, and the edges are represented as tuples (node, weight). The graph can have up to 10^4 nodes, and the weight of each edge is a non-negative integer.
- source (int): The node from which the shortest path is to be found.
- destination (int): The node to which the shortest path is to be found.

Output:
- List<int>: The shortest path from the source node to the destination node. If there are multiple shortest paths, return any valid path.

Example:
Input: graph = { 1: [(2, 5), (3, 3)], 2: [(4, 2)], 3: [(2, 1), (4, 6)], 4: [(5, 1)], 5: [(3, 4)] }, source = 1, destination = 4
Output: [1, 3, 2, 4]
Explanation: The shortest path from node 1 to node 4 is [1, 3, 2, 4] with a total weight of 4.

Input: graph = { 1: [(2, 10), (3, 5)], 2: [(3, 2), (4, 1)], 3: [(2, 3), (5, 2)], 4: [(5, 4)], 5: [] }, source = 1, destination = 5
Output: [1, 3, 5]
Explanation: The shortest path from node 1 to node 5 is [1, 3, 5] with a total weight of 7.

Notes:
- If there is no path from the source node to the destination node, return an empty list.
- Your solution should have a time complexity of O(E + V*log(V)), where E is the number of edges and V is the number of vertices in the graph.
- Your solution should use Dijkstra's algorithm or any other efficient algorithm for finding the shortest path in a weighted graph.
- You may assume that the graph is acyclic and connected, meaning there are no cycles, and there is a path from the source to the destination.
