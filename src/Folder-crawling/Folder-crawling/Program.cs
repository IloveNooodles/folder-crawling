using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace Folder_crawling
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            //create a form 
            Form form = new Form();
            //create a viewer object
            GViewer viewer = new GViewer();
            //create a graph object 
            Graph graph = new Graph("graph");
            DFS(args[0], graph);
        }

        public static void BFS(string root, Graph g)
        {
            Stack<string> dir = new Stack<string>(50);
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dir.Push(root);
            while (dir.Count > 0)
            {
                string cur = dir.Pop();
                string[] sub;
                sub = Directory.GetDirectories(cur);
                string[] files;
                files = Directory.GetFiles(cur);
                foreach (string file in files)
                {
                    g.AddEdge(root, file);
                }
                foreach (string a in sub)
                {
                    g.AddEdge(root, a);
                    dir.Push(a);
                }
            }
        }
        public static void DFS(string root, Graph graph)
        {
            if (!System.IO.Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            string[] sub;
            sub = Directory.GetDirectories(root);
            foreach (string a in sub)
            {
                graph.AddEdge(root, a);
                DFS(a, graph);
            }
            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files)
            {
                graph.AddEdge(root, file);
            }
        }
    }
}
