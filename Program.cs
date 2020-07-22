using System;
using System.Collections.Generic;

namespace algos
{

    class Program
    {
        private int _v;
        List<int>[] adj = null;
        Program(int v)
        {
            _v = v;
            adj = new List<int>[v];
            for (int i = 0; i < v; ++i)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }
        public void DfsUtil(int v, bool[] vistited)
        {
            vistited[v] = true;
            List<int> Vlist = adj[v];

             Console.Write(v + " "); 

            foreach (var n in Vlist)
            {
                if (!vistited[n])
                    DfsUtil(n, vistited);
            }
        }
        public void DFS(int v)
        {
            bool[] vistited = new bool[_v];

            DfsUtil(v, vistited);
        }

        public static void MainC(string[] args)
        {
            Program g = new Program(4);

            g.AddEdge(0, 1);
            g.AddEdge(0, 2);
            g.AddEdge(1, 2);
            g.AddEdge(2, 0);
            g.AddEdge(2, 3);
            g.AddEdge(3, 3);

            Console.WriteLine("Following is Depth First Traversal " +
                              "(starting from vertex 2)");

            g.DFS(2);
           
        }

    }
}

