using System;
using System.Collections;
using System.Collections.Generic;

namespace shortalgos
{
  class Graph { 
    // A class to represent a weighted edge in graph 
    class Edge { 
        public int src, dest, weight; 
        public Edge() 
        { 
            src = dest = weight = 0; 
        } 
    }; 
  
    int V, E; 
    Edge[] edge; 
  
    // Creates a graph with V vertices and E edges 
    Graph(int v, int e) 
    { 
        V = v; 
        E = e; 
        edge = new Edge[e]; 
        for (int i = 0; i < e; ++i) 
            edge[i] = new Edge(); 
    } 

        public void BellmanfordAlgo(Graph graph, int src)
        {
            int V = graph.V, E = graph.E;
            int[] dist = new int[V];

            // Step 1: Initialize distances from src to all other 
            // vertices as INFINITE 
            for (int i = 0; i < V; ++i)
                dist[i] = int.MaxValue;
            dist[src] = 0;

            for (int i = 1; i < V; i++)
            {
                for (int j = 0; j < E; j++)
                {
                    int u = graph.edge[j].src;
                    int v = graph.edge[j].dest;
                    int weight = graph.edge[j].weight;
                    if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])

                        dist[v] = dist[u] + weight;


                }
            }

            for (int j = 0; j < E; ++j)
            {
                int u = graph.edge[j].src;
                int v = graph.edge[j].dest;
                int weight = graph.edge[j].weight;
                if (dist[u] != int.MaxValue && dist[u] + weight < dist[v])
                {
                    Console.WriteLine("Graph contains negative weight cycle");
                    return;
                }
            }
            printSolution(dist, V);

        }




        void printSolution(int[] dist, int V)
        {
            Console.Write("Vertex \t\t Distance "
                          + "from Source\n");
            for (int i = 0; i < V; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }
        public static void MainC(string[] args)
        {
        
            int V = 5; // Number of vertices in graph 
        int E = 8; // Number of edges in graph 
  
        Graph graph = new Graph(V, E); 
  
        // add edge 0-1 (or A-B in above figure) 
        graph.edge[0].src = 0; 
        graph.edge[0].dest = 1; 
        graph.edge[0].weight = -1; 
  
        // add edge 0-2 (or A-C in above figure) 
        graph.edge[1].src = 0; 
        graph.edge[1].dest = 2; 
        graph.edge[1].weight = 4; 
  
        // add edge 1-2 (or B-C in above figure) 
        graph.edge[2].src = 1; 
        graph.edge[2].dest = 2; 
        graph.edge[2].weight = 3; 
  
        // add edge 1-3 (or B-D in above figure) 
        graph.edge[3].src = 1; 
        graph.edge[3].dest = 3; 
        graph.edge[3].weight = 2; 
  
        // add edge 1-4 (or A-E in above figure) 
        graph.edge[4].src = 1; 
        graph.edge[4].dest = 4; 
        graph.edge[4].weight = 2; 
  
        // add edge 3-2 (or D-C in above figure) 
        graph.edge[5].src = 3; 
        graph.edge[5].dest = 2; 
        graph.edge[5].weight = 5; 
  
        // add edge 3-1 (or D-B in above figure) 
        graph.edge[6].src = 3; 
        graph.edge[6].dest = 1; 
        graph.edge[6].weight = 1; 
  
        // add edge 4-3 (or E-D in above figure) 
        graph.edge[7].src = 4; 
        graph.edge[7].dest = 3; 
        graph.edge[7].weight = -3; 
  
        graph.BellmanfordAlgo(graph, 0); 

        }
    }
}

