using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.IO;

namespace Folder_crawling
{
    internal class Algorithm
    {
        public static void DFS(string root, string target, Graph listDirectory, ref bool search, List<string> listAns, bool allOcurence, ref List<string> fullPath)
        {
            //if not found throw exc
            if (!Directory.Exists(root))
            {
                throw new Exception("Folder didn't exists! Please choose correct folder");
            }

            //if the target has been found and searching for one file only, break.
            if (search && !allOcurence)
            {
                return;
            }

            string[] subDir;
            subDir = Directory.GetDirectories(root);

            //traverse deeper to the root folder
            foreach (string dir in subDir)
            {
                if (search && !allOcurence)
                {
                    return;
                }
                ChangeLabel(listDirectory, root, dir);
                DFS(dir, target, listDirectory, ref search, listAns, allOcurence, ref fullPath);
            }

            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files)
            {
                if (search && !allOcurence)
                {
                    return;
                }
                //get the detail of the file
                FileInfo fileInfo = new FileInfo(file);
                ChangeLabel(listDirectory, root, file);
                if (fileInfo.Exists && fileInfo.Name == target)
                {
                    string s = fileInfo.FullName;
                    fullPath.Add(s);
                    listAns.Add(file);
                    if (!allOcurence)
                    {
                        search = true;
                        break;
                    }
                }
            }
        }

        //get file in each dir 
        public static void BFS(string root, string target, Graph listDirectory, List<string> listAns, bool allOcurence, ref List<string> fullPath)
        {
            //if not found throw exc
            if (!Directory.Exists(root))
            {
                throw new Exception("No directory exists! Please insert correct folder");
            }
            Queue<string> queueDir = new Queue<string>();
            queueDir.Enqueue(root);
            while (queueDir.Count > 0)
            {
                string dir = queueDir.Dequeue();
                if (dir != root)
                {
                    Node now = listDirectory.FindNode(dir);
                    //color the curNode, edge, and sourceNode
                    foreach (Edge inEdge in now.InEdges)
                    {
                        inEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        now.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        inEdge.SourceNode.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                    }
                }
                //Get the info on subDir, files, and the dir itself
                DirectoryInfo dirInfo = new DirectoryInfo(dir);
                string[] subDir, files;
                subDir = Directory.GetDirectories(dir);
                files = Directory.GetFiles(dir);

                //iterate all file in current Directory and process (addNode, addEdge, color the node and edge)
                foreach (string file in files)
                {
                    FileInfo fileInfo = new FileInfo(file);
                    ChangeLabel(listDirectory, dir, file);
                    if (fileInfo.Exists && fileInfo.Name == target)
                    {
                        string s = fileInfo.FullName;
                        fullPath.Add(s);
                        listAns.Add(file);
                        if(!allOcurence)  
                        {
                            return;
                        }
                    }
                }

                //iterate all subdirectories in current Directory and process (addNode, addEdge)
                foreach (string curDir in subDir)
                {
                    DirectoryInfo directoryInfo = new DirectoryInfo(curDir);
                    listDirectory.AddEdge(dir, curDir);
                    listDirectory.FindNode(dir).LabelText = dirInfo.Name;
                    listDirectory.FindNode(curDir).LabelText = directoryInfo.Name;
                    queueDir.Enqueue(curDir);
                }
            }
        }

        //color the edge and the node red
        public static void ChangeLabel(Graph listDirectory, string src, string target)
        {
            FileInfo _src = new FileInfo(src);
            FileInfo _target = new FileInfo(target);
            listDirectory.AddEdge(src, target).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            listDirectory.FindNode(src).LabelText = _src.Name;
            listDirectory.FindNode(src).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            listDirectory.FindNode(target).LabelText = _target.Name;
            listDirectory.FindNode(target).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
        }

        public static void graphColoring (Graph listDirectory, string src, List<string> listAns)
        {
            //if no ans found don't bother
            if (listAns.Count == 0)
            {
                return;
            }
            //traverse from ans to root
            Node dir;
            foreach (string ans in listAns)
            {
                string traverse = ans;
                while (src != traverse)
                {
                    dir = listDirectory.FindNode(traverse);
                    dir.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                    foreach (Edge inEdge in dir.InEdges)
                    {
                        inEdge.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                        dir = inEdge.SourceNode;
                    }
                    traverse = dir.Id;
                }
            }
            //change the root to green
            dir = listDirectory.FindNode (src);
            dir.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
        }
    }
}
