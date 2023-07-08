using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public List<int> ShortestPath(Dictionary<int, List<(int, int)>> graph, int source, int destination)
    {
        if (!graph.ContainsKey(source) || !graph.ContainsKey(destination))
            return new List<int>();

        Dictionary<int, int> distance = new Dictionary<int, int>();
        Dictionary<int, int> previousNode = new Dictionary<int, int>();
        foreach (int node in graph.Keys)
        {
            distance[node] = int.MaxValue;
            previousNode[node] = -1;
        }
        distance[source] = 0;

        PriorityQueue<(int, int)> minHeap = new PriorityQueue<(int, int)>((a, b) => a.Item2.CompareTo(b.Item2));
        minHeap.Enqueue((source, 0));

        while (minHeap.Count > 0)
        {
            (int currentNode, int currentDistance) = minHeap.Dequeue();
            if (currentDistance > distance[currentNode])
                continue;

            foreach ((int nextNode, int weight) in graph[currentNode])
            {
                int newDistance = distance[currentNode] + weight;
                if (newDistance < distance[nextNode])
                {
                    distance[nextNode] = newDistance;
                    previousNode[nextNode] = currentNode;
                    minHeap.Enqueue((nextNode, newDistance));
                }
            }
        }

        if (distance[destination] == int.MaxValue)
            return new List<int>();

        List<int> shortestPath = new List<int>();
        int currentNode = destination;
        while (currentNode != -1)
        {
            shortestPath.Insert(0, currentNode);
            currentNode = previousNode[currentNode];
        }

        return shortestPath;
    }

    // Priority Queue implementation for Dijkstra's algorithm
    public class PriorityQueue<T>
    {
        private List<T> list;
        private Comparison<T> comparison;

        public int Count => list.Count;

        public PriorityQueue(Comparison<T> comparison)
        {
            list = new List<T>();
            this.comparison = comparison;
        }

        public void Enqueue(T item)
        {
            list.Add(item);
            int i = list.Count - 1;
            while (i > 0)
            {
                int parentIndex = (i - 1) / 2;
                if (comparison(list[parentIndex], item) <= 0)
                    break;
                list[i] = list[parentIndex];
                i = parentIndex;
            }
            list[i] = item;
        }

        public T Dequeue()
        {
            if (list.Count == 0)
                throw new InvalidOperationException("PriorityQueue is empty.");

            T frontItem = list[0];
            int lastIndex = list.Count - 1;
            T lastItem = list[lastIndex];
            list.RemoveAt(lastIndex);

            if (list.Count > 0)
            {
                int i = 0;
                while (true)
                {
                    int leftChildIndex = 2 * i + 1;
                    int rightChildIndex = 2 * i + 2;
                    if (leftChildIndex >= list.Count)
                        break;
                    int smallerChildIndex = rightChildIndex < list.Count && comparison(list[rightChildIndex], list[leftChildIndex]) < 0 ? rightChildIndex : leftChildIndex;
                    if (comparison(list[smallerChildIndex], lastItem) >= 0)
                        break;
                    list[i] = list[smallerChildIndex];
                    i = smallerChildIndex;
                }
                list[i] = lastItem;
            }

            return frontItem;
        }
    }
}
