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
        static void Main()
        {
            Form form = new Form();
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");

            //input
            string args = Console.ReadLine();
            string target = Console.ReadLine();
            string ans = "";
            Boolean found = false;

            //process
            BFS(args, target, graph, ref ans);
            //change color answer path
            Coloring(graph, args, ans);

            //visualization
            viewer.Graph = graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.ShowDialog();
        }

        public static void BFS(string root,string target, Graph g, ref string ans)
        {
            Queue<string> dir = new Queue<string>(50);
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            dir.Enqueue(root);
            while (dir.Count > 0)
            {
                string cur = dir.Dequeue();
                //change color to red because visited
                if (cur != root)
                {
                    Node now = g.FindNode(cur);
                    foreach (Edge e in now.InEdges)
                    {
                        e.Attr.Color = Color.Red;
                        now.Attr.FillColor = Color.Red;
                        e.SourceNode.Attr.FillColor = Color.Red;
                    }
                }
                DirectoryInfo ro = new DirectoryInfo(cur);
                string[] sub, files;
                sub = Directory.GetDirectories(cur);
                files = Directory.GetFiles(cur);
                //iterate all file in current Directory and process (addNode, addEdge, color the node and edge)
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    ChangeLabel(g, cur, file);
                    if (fi.Name == target) // check if this is goal
                    {
                        ans = file;
                        return;
                    }
                }
                //iterate all subdirectories in current Directory and process (addNode, addEdge)
                foreach (string a in sub)
                {
                    DirectoryInfo fo = new DirectoryInfo(a);
                    g.AddEdge(cur, a);
                    g.FindNode(cur).LabelText = ro.Name;
                    g.FindNode(a).LabelText = fo.Name;
                    dir.Enqueue(a); //enqueue all subdirectory to queue dir (for process)
                }
            }
        }
        public static void DFS(string root, string target, Graph graph, ref Boolean search, ref string ans)
        {
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            //if already found, stop the dfs
            if (search)
            {
                return;
            }
            string[] sub;
            sub = Directory.GetDirectories(root);
            foreach (string a in sub)
            {
                if (search) //if goal found, stop the iterate
                {
                    return;
                }
                ChangeLabel(graph, root, a); //addEdge, addNode, and change color node and edge
                DFS(a, target, graph, ref search, ref ans); //recursive function for DFS algorithm
            }
            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files) //iterate all file in the current directory
            {
                if (search) //if goal found, stop the iterate
                {
                    return;
                }
                FileInfo fi = new FileInfo(file);
                ChangeLabel(graph, root, file); //addEdge, addNode, and change color node and edge
                if (fi.Name == target) //this is goal state
                {
                    ans = file;
                    search = true;
                    break;
                }
            }
        }
        public static void ChangeLabel(Graph g, string src, string target) //procedure to process the graph
        {
            FileInfo _src = new FileInfo(src);
            FileInfo _target = new FileInfo(target);
            g.AddEdge(src, target).Attr.Color = Color.Red;
            g.FindNode(src).Attr.FillColor = Color.Red;
            g.FindNode(target).Attr.FillColor = Color.Red;
            g.FindNode(src).LabelText = _src.Name;
            g.FindNode(target).LabelText = _target.Name;
        }
        public static void Coloring(Graph g, string src, string ans) //procedure to change the color of path from source to answer
        {
            if (ans == "")
            {
                return;
            }
            Node now;
            while (src != ans)
            {
                now = g.FindNode(ans);
                now.Attr.FillColor = Color.Green;
                foreach (Edge e in now.InEdges)
                {
                    e.Attr.Color = Color.Green;
                    now = e.SourceNode;
                }
                ans = now.Id;
            }
            now = g.FindNode(src);
            now.Attr.FillColor = Color.Green;
        }
    }
}
