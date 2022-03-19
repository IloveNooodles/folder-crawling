using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;
using System.IO;

namespace Folder_crawling
{
    public partial class Form1 : Form
    {
        string src;
        string target;
        string choose;
        Boolean allOccurence;

        public Form1()
        {
            InitializeComponent();
        }
        public static void BFS_Method(string root,string target, Graph g,List<string> ans, Boolean allOccurence)
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
                        e.Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                        now.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                        e.SourceNode.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
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
                        ans.Add(file);
                        if (!allOccurence)
                        {
                            return;
                        }
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
        public static void DFS_Method(string root, string target, Graph graph, ref Boolean search, List<string> ans, Boolean allOccurence)
        {
            if (!Directory.Exists(root))
            {
                throw new ArgumentException();
            }
            //if already found, stop the dfs
            if (search && !allOccurence)
            {
                return;
            }
            string[] sub;
            sub = Directory.GetDirectories(root);
            foreach (string a in sub)
            {
                if (search && !allOccurence) //if goal found, stop the iterate
                {
                    return;
                }
                ChangeLabel(graph, root, a); //addEdge, addNode, and change color node and edge
                DFS_Method(a, target, graph, ref search, ans, allOccurence); //recursive function for DFS algorithm
            }
            string[] files;
            files = Directory.GetFiles(root);
            foreach (string file in files) //iterate all file in the current directory
            {
                if (search && !allOccurence) //if goal found, stop the iterate
                {
                    return;
                }
                FileInfo fi = new FileInfo(file);
                ChangeLabel(graph, root, file); //addEdge, addNode, and change color node and edge
                if (fi.Name == target) //this is goal state
                {
                    ans.Add(file);
                    if (!allOccurence)
                    {
                        search = true;
                        break;
                    }
                }
            }
        }
        public static void ChangeLabel(Graph g, string src, string target) //procedure to process the graph
        {
            FileInfo _src = new FileInfo(src);
            FileInfo _target = new FileInfo(target);
            g.AddEdge(src, target).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
            g.FindNode(src).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            g.FindNode(target).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            g.FindNode(src).LabelText = _src.Name;
            g.FindNode(target).LabelText = _target.Name;
        }
        public static void Coloring(Graph g, string src, List<string> ans) //procedure to change the color of path from source to answer
        {
            if (ans.Count == 0)
            {
                return;
            }
            Node now;
            foreach(string x in ans)
            {
                string n = x;
                while (src != n)
                {
                    now = g.FindNode(n);
                    now.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
                    foreach (Edge e in now.InEdges)
                    {
                        e.Attr.Color = Microsoft.Msagl.Drawing.Color.Green;
                        now = e.SourceNode;
                    }
                    n = now.Id;
                }
            }
            now = g.FindNode(src);
            now.Attr.FillColor = Microsoft.Msagl.Drawing.Color.Green;
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
                src = folderBrowserDialog1.SelectedPath;
                label8.Text = folderBrowserDialog1.SelectedPath;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.SearchFile.BackColor = System.Drawing.Color.Violet;
            this.SearchFile.FlatStyle = FlatStyle.Flat;
            this.SearchFile.FlatAppearance.BorderColor = System.Drawing.Color.Tomato; 
            this.SearchFile.FlatAppearance.BorderSize = 1;
            Form form = new Form();
            GViewer viewer = new GViewer();
            Graph graph = new Graph("graph");
            List<string> ans = new List<string>();
            if (choose == "DFS")
            {
                Boolean found = false;
                DFS_Method(src, target, graph, ref found, ans, allOccurence);
            }
            else if (choose == "BFS")
            {
                BFS_Method(src, target, graph, ans, allOccurence);
            }
            Coloring(graph, src, ans);
            viewer.Graph = graph;
            form.SuspendLayout();
            viewer.Dock = DockStyle.Fill;
            form.Controls.Add(viewer);
            form.ResumeLayout();
            form.ShowDialog();
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
            if (BFS.Checked)
            {
                choose = "BFS";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (DFS.Checked)
            {
                choose = "DFS";
            }
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FileName_TextChanged(object sender, EventArgs e)
        {
            target = FileName.Text;
        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
