using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Folder_crawling
{
    internal class Graph
    {
        private int vertices;
        private List<int>[] adj;
        private List<int> solution;

        public Graph(int vertices)
        {
            this.vertices = vertices;
            adj = new List<int>[vertices];
            for (int i = 0; i < vertices; i++)
            {
                adj[i] = new List<int>();
            }
        }
        public void AddEdge(int v, int w)
        {
            adj[v].Add(w);
        }

        public int getVertices()
        {
            return this.vertices;
        }

        public void setVertices(int vertices)
        {
            this.vertices = vertices;
        }

        public List<int>[] getAdj()
        {
            return this.adj;
        }

        public List<int> getSolution()
        {
            return this.solution;
        }

        public void DFSUtil(int v, bool[] visited)
        {
            visited[v] = true;
            Console.Write(v + " ");

            List<int> vList = adj[v];
            foreach (var n in vList)
            {
                if (!visited[n])
                {
                    DFSUtil(n, visited);
                }
            }
        }

        public void DFS(int v)
        {
            bool[] visited = new bool[v];
            for (int i = 0; i < this.vertices; i++)
            {
                visited[i] = false;
            }
            DFSUtil(v, visited);
        }

        public void BFS(int source)
        {
            bool[] visited = new bool[this.vertices];
            for (int i = 0; i < this.vertices; i++)
            {
                visited[i] = false;
            }
            Queue<int> q = new Queue<int>();
            visited[source] = true;
            q.Enqueue(source);
            while(q.Count > 0)
            {
                int node = q.Dequeue();
                Console.Write(node + " ");

                List<int> l = this.adj[node];
                foreach (int n in l)
                {
                    if (!visited[n])
                    {
                        visited[n] = true;
                        q.Enqueue(n);
                    }
                }

            }
        }
    }
}