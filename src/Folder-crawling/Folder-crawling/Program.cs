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

            string args = Console.ReadLine();
            string target = Console.ReadLine();
            Boolean found = false;
            DFS(args, target, graph, ref found);
            
            viewer.Graph = graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.ShowDialog();

        }

        public static void BFS(string root,string target, Graph g)
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
                DirectoryInfo ro = new DirectoryInfo(cur);
                string[] sub;
                sub = Directory.GetDirectories(cur);
                string[] files;
                files = Directory.GetFiles(cur);
                foreach (string file in files)
                {
                    FileInfo fi = new FileInfo(file);
                    g.AddEdge(ro.Name, fi.Name);
                    if (fi.Name == target)
                    {
                        return;
                    }
                }
                foreach (string a in sub)
                {
                    DirectoryInfo fo = new DirectoryInfo(a);
                    g.AddEdge(ro.Name, fo.Name);
                    dir.Enqueue(a);
                }
            }
        }
        public static void DFS(string root, string target, Graph graph, ref Boolean search)
        {
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            if (search)
            {
                return;
            }
            DirectoryInfo ro = new DirectoryInfo(root);
            string[] sub;
            sub = Directory.GetDirectories(root);
            foreach (string a in sub)
            {
                if (search)
                {
                    return;
                }
                DirectoryInfo fo = new DirectoryInfo(a);
                graph.AddEdge(ro.Name, fo.Name);
                DFS(a, target, graph, ref search);
            }
            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files)
            {
                FileInfo fi = new FileInfo(file);
                graph.AddEdge(ro.Name, fi.Name);
                if (fi.Name == target)
                {
                    search = true;
                    return;
                }
            }
        }
    }
}
