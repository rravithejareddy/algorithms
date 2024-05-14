using System;
using System.Collections.Generic;

class Graph
{
    private int _v;

    private List<int>[] _adj = null;
    public Graph(int v)
    {
        _v = v;
        _adj = new List<int>[v];
        for (int i = 0; i < v; i++)
        {
            _adj[i] = new List<int>();
        }
    }

    void addEdge(int v, int w)
    {
        _adj[v].Add(w);
    }

    void DFSUtil(int n, bool[] visited)
    {
        visited[n] = true;
        Console.Write(n + " ");
        foreach (int i in _adj[n])
        {
            int v = i;
            if (!visited[v])
                DFSUtil(v, visited);
        }
    }

    void DFS()
    {
        bool[] visited = new bool[_v];


        for (int i = 0; i < _v; i++)
        {
            if (!visited[i])
                DFSUtil(i, visited);
        }
    }

    public static void MainC()
    {
        Graph g = new Graph(4);

        g.addEdge(0, 1);
        g.addEdge(0, 2);
        g.addEdge(1, 2);
        g.addEdge(2, 0);
        g.addEdge(2, 3);
        g.addEdge(3, 3);

        Console.WriteLine(
            "Following is Depth First Traversal");

        g.DFS();

    }
}