﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.IO;

namespace Folder_crawling
{
    public partial class Form1 : Form
    {
        GViewer viewer = new GViewer();
        string src;
        string target;
        bool allOccurence;
        List<string> pathFile;
        public void DFS_method(string root, string target, Graph listDirectory, ref bool search, List<string> listAns, bool allOcurence, ref List<string> fullPath)
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
                wait(500);
                if (search && !allOcurence)
                {
                    return;
                }
                ChangeLabel(listDirectory, root, dir);
                show(viewer, listDirectory);
                DFS_method(dir, target, listDirectory, ref search, listAns, allOcurence, ref fullPath);
            }

            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files)
            {
                wait(500);
                if (search && !allOcurence)
                {
                    return;
                }
                //get the detail of the file
                FileInfo fileInfo = new FileInfo(file);
                ChangeLabel(listDirectory, root, file);
                show(viewer, listDirectory);
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
        public void BFS_method(string root, string target, Graph listDirectory, List<string> listAns, bool allOcurence, ref List<string> fullPath)
        {
            panel1.Controls.Clear();
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
                        wait(500);
                        inEdge.Attr.Color = Color.Red;
                        now.Attr.Color = Color.Red;
                        inEdge.SourceNode.Attr.Color = Color.Red;
                        show(viewer, listDirectory);
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
                    wait(500);
                    FileInfo fileInfo = new FileInfo(file);
                    ChangeLabel(listDirectory, dir, file);
                    if (fileInfo.Exists && fileInfo.Name == target)
                    {
                        string s = fileInfo.FullName;
                        fullPath.Add(s);
                        listAns.Add(file);
                        if (!allOcurence)
                        {
                            return;
                        }
                    }
                    show(viewer, listDirectory);
                }

                //iterate all subdirectories in current Directory and process (addNode, addEdge)
                foreach (string curDir in subDir)
                {
                    wait(500);
                    DirectoryInfo directoryInfo = new DirectoryInfo(curDir);
                    listDirectory.AddEdge(dir, curDir);
                    listDirectory.FindNode(dir).LabelText = dirInfo.Name;
                    listDirectory.FindNode(curDir).LabelText = directoryInfo.Name;
                    queueDir.Enqueue(curDir);
                    show(viewer, listDirectory);
                }
            }
        }

        //color the edge and the node red
        public static void ChangeLabel(Graph listDirectory, string src, string target)
        {
            FileInfo _src = new FileInfo(src);
            FileInfo _target = new FileInfo(target);
            listDirectory.AddEdge(src, target).Attr.Color = Color.Red;
            listDirectory.FindNode(src).LabelText = _src.Name;
            listDirectory.FindNode(src).Attr.Color = Color.Red;
            listDirectory.FindNode(target).LabelText = _target.Name;
            listDirectory.FindNode(target).Attr.Color = Color.Red;
        }

        public void graphColoring(Graph listDirectory, string src, List<string> listAns)
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
                    dir.Attr.FillColor = Color.Green;
                    foreach (Edge inEdge in dir.InEdges)
                    {
                        inEdge.Attr.Color = Color.Green;
                        dir = inEdge.SourceNode;
                    }
                    traverse = dir.Id;
                }
                dir = listDirectory.FindNode(src);
                dir.Attr.FillColor = Color.Green;
                show(viewer, listDirectory);
            }
        }
        public void wait(int milliseconds)
        {
            var timer1 = new Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        public void show(GViewer viewer, Graph g)
        {
            viewer.Graph = g;
            panel1.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            panel1.Controls.Add(viewer);
            panel1.ResumeLayout();
        }
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            allOccurence = FindAll.Checked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.src = folderBrowserDialog1.SelectedPath;
                this.label8.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            filePath.Text = "";
            pathFile = new List<string>();
            Graph graph = new Graph("graph");
            List<string> ans = new List<string>();
            if (DFS.Checked)
            {
                panel1.Controls.Clear();
                bool found = false;
                DFS_method(src, target, graph, ref found, ans, allOccurence, ref pathFile);
            }
            else if (BFS.Checked)
            {
                BFS_method(src, target, graph, ans, allOccurence, ref pathFile);
            }
            graphColoring(graph, src, ans);


            foreach (string text in pathFile)
            {
                this.filePath.Text += text + "\n";
            }

            //stopwatch stop
            stopwatch.Stop();
            TimeSpan ts = stopwatch.Elapsed;
            string elapsedTime = String.Format("{0:00}.{1:00} ms", ts.Seconds, ts.Milliseconds / 10);
            this.elapsedTime.Text += elapsedTime;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
            this.target = FileName.Text;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void time_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
    }
}
