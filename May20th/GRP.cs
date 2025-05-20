using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    
    class GraphAlgorithm
    {
        public static void Dijkstra(int[,] graph, int source, int numVertices)
        {
            // Initialize distance array and path array
            int[] dist = new int[numVertices];
            int[] prev = new int[numVertices];
            bool[] visited = new bool[numVertices];

            // Initialize all distances to infinity, and previous nodes to -1
            for (int i = 0; i < numVertices; i++)
            {
                dist[i] = int.MaxValue;
                prev[i] = -1;
                visited[i] = false;
            }

            dist[source] = 0;

            // Dijkstra's algorithm main loop
            for (int count = 0; count < numVertices - 1; count++)
            {
                // Find the vertex with the minimum distance value that has not been visited
                int u = FindMinDistanceNode(dist, visited, numVertices);
                visited[u] = true;

                // Update the distance values of adjacent vertices of the selected node
                for (int v = 0; v < numVertices; v++)
                {
                    // Update dist[v] if the current node u is not visited, and there's a shorter path to v
                    if (!visited[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                    {
                        dist[v] = dist[u] + graph[u, v];
                        prev[v] = u;
                    }
                }
            }

            // Output the shortest distance and the path for each node
            Console.WriteLine("Shortest distances from node " + source + ":");
            for (int i = 0; i < numVertices; i++)
            {
                Console.WriteLine($"Node {i}: Distance = {dist[i]}, Path = {GetPath(prev, i)}");
            }
        }

        // Method to find the node with the minimum distance that is not yet visited
        private static int FindMinDistanceNode(int[] dist, bool[] visited, int numVertices)
        {
            int min = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < numVertices; i++)
            {
                if (!visited[i] && dist[i] < min)
                {
                    min = dist[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }

        // Method to construct the path from the previous node array
        private static string GetPath(int[] prev, int node)
        {
            string path = "";
            while (node != -1)
            {
                path = node + " " + path;
                node = prev[node];
            }
            return path.Trim();
        }

        public static void Main()
        {
            // Example input: 5 nodes and custom edge weights
            int numVertices = 5;
            int[,] graph = new int[,] {
            { 0, 10, 0, 30, 0 },
            { 10, 0, 50, 0, 0 },
            { 0, 50, 0, 20, 10 },
            { 30, 0, 20, 0, 60 },
            { 0, 0, 10, 60, 0 }
        };

            // Ask the user for the source node
            Console.WriteLine("Enter the source node (0 to " + (numVertices - 1) + "): ");
            int source = int.Parse(Console.ReadLine());

            Dijkstra(graph, source, numVertices);
        }
        }
}