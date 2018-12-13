namespace WindowsFormsApp1
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Names");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("reg.no");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Students", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Room1");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Room2");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Rooms", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Calculator");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Utilities", new System.Windows.Forms.TreeNode[] {
            treeNode7});
            this.jijo = new System.Windows.Forms.Panel();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // jijo
            // 
            this.jijo.Location = new System.Drawing.Point(169, 13);
            this.jijo.Name = "jijo";
            this.jijo.Size = new System.Drawing.Size(530, 402);
            this.jijo.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 13);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node1";
            treeNode1.Text = "Names";
            treeNode2.Name = "Node2";
            treeNode2.Text = "reg.no";
            treeNode3.Name = "Node0";
            treeNode3.Text = "Students";
            treeNode4.Name = "Node4";
            treeNode4.Text = "Room1";
            treeNode5.Name = "Node5";
            treeNode5.Text = "Room2";
            treeNode6.Name = "Node3";
            treeNode6.Text = "Rooms";
            treeNode7.Name = "Node7";
            treeNode7.Text = "Calculator";
            treeNode8.Name = "Node6";
            treeNode8.Text = "Utilities";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode6,
            treeNode8});
            this.treeView1.Size = new System.Drawing.Size(151, 402);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 427);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.jijo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel jijo;
        private System.Windows.Forms.TreeView treeView1;
    }
}

