namespace Folder_crawling
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.StartingFolder = new System.Windows.Forms.Button();
            this.FindAll = new System.Windows.Forms.CheckBox();
            this.SearchFile = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.FileName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.BFS = new System.Windows.Forms.RadioButton();
            this.DFS = new System.Windows.Forms.RadioButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.filePath = new System.Windows.Forms.Label();
            this.time = new System.Windows.Forms.Label();
            this.elapsedTime = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.placeholder = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.curTime = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.listView4 = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(577, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(330, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Folder Crawling";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(841, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 44);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(114, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 44);
            this.label3.TabIndex = 2;
            this.label3.Text = "Input";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.WindowText;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(-20, 88);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(361, 573);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // StartingFolder
            // 
            this.StartingFolder.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StartingFolder.FlatAppearance.BorderSize = 3;
            this.StartingFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StartingFolder.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartingFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.StartingFolder.Location = new System.Drawing.Point(57, 285);
            this.StartingFolder.Name = "StartingFolder";
            this.StartingFolder.Size = new System.Drawing.Size(215, 48);
            this.StartingFolder.TabIndex = 5;
            this.StartingFolder.Text = "Choose Folder";
            this.StartingFolder.UseVisualStyleBackColor = false;
            this.StartingFolder.Click += new System.EventHandler(this.button1_Click);
            // 
            // FindAll
            // 
            this.FindAll.AutoSize = true;
            this.FindAll.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FindAll.FlatAppearance.CheckedBackColor = System.Drawing.Color.IndianRed;
            this.FindAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FindAll.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FindAll.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FindAll.Location = new System.Drawing.Point(57, 388);
            this.FindAll.Name = "FindAll";
            this.FindAll.Size = new System.Drawing.Size(179, 26);
            this.FindAll.TabIndex = 6;
            this.FindAll.Text = "Find All occurence";
            this.FindAll.UseVisualStyleBackColor = false;
            this.FindAll.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // SearchFile
            // 
            this.SearchFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.SearchFile.FlatAppearance.BorderSize = 0;
            this.SearchFile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.SearchFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchFile.Font = new System.Drawing.Font("Montserrat SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchFile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SearchFile.Location = new System.Drawing.Point(58, 520);
            this.SearchFile.Name = "SearchFile";
            this.SearchFile.Size = new System.Drawing.Size(221, 56);
            this.SearchFile.TabIndex = 7;
            this.SearchFile.Text = "Search";
            this.SearchFile.UseVisualStyleBackColor = false;
            this.SearchFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(54, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Input File Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FileName
            // 
            this.FileName.BackColor = System.Drawing.Color.Black;
            this.FileName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FileName.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FileName.ForeColor = System.Drawing.Color.LightGray;
            this.FileName.Location = new System.Drawing.Point(57, 202);
            this.FileName.Margin = new System.Windows.Forms.Padding(0);
            this.FileName.Multiline = true;
            this.FileName.Name = "FileName";
            this.FileName.Size = new System.Drawing.Size(195, 28);
            this.FileName.TabIndex = 9;
            this.FileName.Text = " Your File Here";
            this.FileName.TextChanged += new System.EventHandler(this.FileName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(54, 256);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(217, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Starting Directory/Folder";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(53, 429);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 22);
            this.label6.TabIndex = 11;
            this.label6.Text = "Search Method";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // BFS
            // 
            this.BFS.AutoSize = true;
            this.BFS.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BFS.Cursor = System.Windows.Forms.Cursors.Default;
            this.BFS.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.BFS.Location = new System.Drawing.Point(57, 454);
            this.BFS.Name = "BFS";
            this.BFS.Size = new System.Drawing.Size(57, 25);
            this.BFS.TabIndex = 12;
            this.BFS.Text = "BFS";
            this.BFS.UseVisualStyleBackColor = true;
            this.BFS.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // DFS
            // 
            this.DFS.AutoSize = true;
            this.DFS.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DFS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.DFS.Location = new System.Drawing.Point(141, 454);
            this.DFS.Name = "DFS";
            this.DFS.Size = new System.Drawing.Size(58, 25);
            this.DFS.TabIndex = 13;
            this.DFS.TabStop = true;
            this.DFS.Text = "DFS";
            this.DFS.UseVisualStyleBackColor = true;
            this.DFS.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Montserrat", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label7.Location = new System.Drawing.Point(627, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(222, 18);
            this.label7.TabIndex = 15;
            this.label7.Text = "The fastest file finder in the world";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.HelpRequest += new System.EventHandler(this.folderBrowserDialog1_HelpRequest);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.label8.Location = new System.Drawing.Point(54, 345);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 21);
            this.label8.TabIndex = 16;
            this.label8.Text = "No File Chosen";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(1046, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 22);
            this.label9.TabIndex = 17;
            this.label9.Text = "Full Path:";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // filePath
            // 
            this.filePath.AutoSize = true;
            this.filePath.Cursor = System.Windows.Forms.Cursors.Default;
            this.filePath.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePath.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filePath.Location = new System.Drawing.Point(485, 155);
            this.filePath.Name = "filePath";
            this.filePath.Size = new System.Drawing.Size(0, 22);
            this.filePath.TabIndex = 18;
            this.filePath.Click += new System.EventHandler(this.label10_Click);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.time.Location = new System.Drawing.Point(1046, 613);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(126, 22);
            this.time.TabIndex = 19;
            this.time.Text = "Elapsed Time:";
            this.time.Click += new System.EventHandler(this.time_Click);
            // 
            // elapsedTime
            // 
            this.elapsedTime.AutoSize = true;
            this.elapsedTime.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elapsedTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elapsedTime.Location = new System.Drawing.Point(521, 520);
            this.elapsedTime.Name = "elapsedTime";
            this.elapsedTime.Size = new System.Drawing.Size(0, 22);
            this.elapsedTime.TabIndex = 20;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.placeholder);
            this.panel1.Location = new System.Drawing.Point(375, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(660, 460);
            this.panel1.TabIndex = 21;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // placeholder
            // 
            this.placeholder.AutoSize = true;
            this.placeholder.Font = new System.Drawing.Font("Montserrat SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placeholder.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.placeholder.Location = new System.Drawing.Point(119, 200);
            this.placeholder.Name = "placeholder";
            this.placeholder.Size = new System.Drawing.Size(439, 44);
            this.placeholder.TabIndex = 27;
            this.placeholder.Text = "Graph will be shown here";
            this.placeholder.Click += new System.EventHandler(this.placeholder_Click);
            // 
            // listView2
            // 
            this.listView2.BackColor = System.Drawing.SystemColors.WindowText;
            this.listView2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listView2.Cursor = System.Windows.Forms.Cursors.Default;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(338, 88);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(1071, 573);
            this.listView2.TabIndex = 22;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged_1);
            // 
            // curTime
            // 
            this.curTime.AutoSize = true;
            this.curTime.Font = new System.Drawing.Font("Montserrat SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curTime.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.curTime.Location = new System.Drawing.Point(1178, 613);
            this.curTime.Name = "curTime";
            this.curTime.Size = new System.Drawing.Size(16, 22);
            this.curTime.TabIndex = 24;
            this.curTime.Text = "-";
            this.curTime.Click += new System.EventHandler(this.curTime_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label10.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(1007, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(370, 22);
            this.label10.TabIndex = 26;
            this.label10.Text = "2022 © C# C# di dinding. All Rights Reserved.";
            // 
            // listView4
            // 
            this.listView4.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView4.HideSelection = false;
            this.listView4.Location = new System.Drawing.Point(-20, -33);
            this.listView4.Name = "listView4";
            this.listView4.Size = new System.Drawing.Size(1429, 126);
            this.listView4.TabIndex = 27;
            this.listView4.UseCompatibleStateImageBehavior = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Location = new System.Drawing.Point(370, 165);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(670, 470);
            this.panel2.TabIndex = 28;
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(0, 87);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1410, 3);
            this.panel3.TabIndex = 29;
            // 
            // panel4
            // 
            this.panel4.Location = new System.Drawing.Point(340, 88);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 563);
            this.panel4.TabIndex = 30;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(-1, 651);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1411, 56);
            this.panel5.TabIndex = 31;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1407, 701);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.curTime);
            this.Controls.Add(this.elapsedTime);
            this.Controls.Add(this.time);
            this.Controls.Add(this.filePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DFS);
            this.Controls.Add(this.BFS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.FileName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SearchFile);
            this.Controls.Add(this.FindAll);
            this.Controls.Add(this.StartingFolder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView4);
            this.Cursor = System.Windows.Forms.Cursors.AppStarting;
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folder Crawling";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button StartingFolder;
        private System.Windows.Forms.CheckBox FindAll;
        private System.Windows.Forms.Button SearchFile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton BFS;
        private System.Windows.Forms.RadioButton DFS;
        public System.Windows.Forms.TextBox FileName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label filePath;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label elapsedTime;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.Label curTime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label placeholder;
        private System.Windows.Forms.ListView listView4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
    }
}

