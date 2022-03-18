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
            //Form form = new Form();
            //GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");
            string args = Console.ReadLine();
            string target = Console.ReadLine();
            DFS(args, graph);
            Console.WriteLine("\n");
            BFS(args, target, graph);
            Console.ReadKey();
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
                string[] sub;
                sub = Directory.GetDirectories(cur);
                string[] files;
                files = Directory.GetFiles(cur);
                foreach (string file in files)
                {
                    Console.WriteLine(file);
                    FileInfo fi = new FileInfo(file);
                    if (fi.Name == target)
                    {
                        Console.WriteLine("File ditemukan");
                        return;
                    }
                }
                foreach (string a in sub)
                {
                    dir.Enqueue(a);
                }
            }
        }
        public static void DFS(string root, Graph graph)
        {
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            string[] sub;
            sub = Directory.GetDirectories(root);
            foreach (string a in sub)
            {
                DFS(a, graph);
            }
            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files)
            {
                Console.WriteLine(file);
            }
        }
    }
}
