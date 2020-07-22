using System;
using System.Collections;
using System.Collections.Generic;

namespace algos
{

    class Graph
    {
        private int _v;
        List<int>[] adj = null;
        Graph(int v)
        {
            _v = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        public void BFS(int s)
        {
            bool[] visited = new bool[_v];

            visited[s] = true;

            Queue<int> q = new Queue<int>();
            q.Enqueue(s);

            while (q.Count != 0)
            {
                s = q.Peek();

                Console.Write(s + " ");
                q.Dequeue();

                foreach (var i in adj[s])
                {
                    if (!visited[i])
                    {
                        visited[i] = true;
                        q.Enqueue(i);
                    }
                }
            }
        }


        public static void MainC(string[] args)
        {
            Graph g = new Graph(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal " +
                              "(starting from vertex 2)");

            g.BFS(2);

        }

    }
}

