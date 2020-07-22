using System;
using System.Collections;
using System.Collections.Generic;

namespace algos
{

    class DijkstrasAlgo
    {
        static int V = 9;
        public int MinimunDistance(int[] dist, bool[] sptSet)
        {
            int min = int.MaxValue; int min_index = -1;


            for (int v = 0; v < V; v++)
            
                if (sptSet[v] == false && dist[v] <= min)
                {
                    min = dist[v];
                    min_index = v;
                }
            

            return min_index;
        }

        public void Dijkstras(int[,] graph, int src)
        {
            int[] dist = new int[V];
            bool[] sptSet = new bool[V];

            for (int i = 0; i < V; i++)
            {
                dist[i] = int.MaxValue;
                sptSet[i] = false;
            }

            dist[src] = 0;

            for (int count = 0; count < V - 1; count++)
            {
                int u = MinimunDistance(dist, sptSet);
                 sptSet[u] = true; 

                for (int v = 0; v < V; v++)
                {
                    if (!sptSet[v] && graph[u, v] != 0 && dist[u] != int.MaxValue && dist[u] + graph[u, v] < dist[v])
                        dist[v] = dist[u] + graph[u, v];
                }
            }

            printSolution(dist);
        }

        void printSolution(int[] dist)
        {
            Console.Write("Vertex \t\t Distance "
                          + "from Source\n");
            for (int i = 0; i < V; i++)
                Console.Write(i + " \t\t " + dist[i] + "\n");
        }
        public static void MainC(string[] args)
        {
            DijkstrasAlgo GFG = new DijkstrasAlgo();

            int[,] graph = new int[,] { { 0, 4, 0, 0, 0, 0, 0, 8, 0 },
                                      { 4, 0, 8, 0, 0, 0, 0, 11, 0 },
                                      { 0, 8, 0, 7, 0, 4, 0, 0, 2 },
                                      { 0, 0, 7, 0, 9, 14, 0, 0, 0 },
                                      { 0, 0, 0, 9, 0, 10, 0, 0, 0 },
                                      { 0, 0, 4, 14, 10, 0, 2, 0, 0 },
                                      { 0, 0, 0, 0, 0, 2, 0, 1, 6 },
                                      { 8, 11, 0, 0, 0, 0, 1, 0, 7 },
                                      { 0, 0, 2, 0, 0, 0, 6, 7, 0 } };

            GFG.Dijkstras(graph, 0);

        }
    }
}

