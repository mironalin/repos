namespace ST03_2_1071_Miron_Alin
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Brand");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Tractors", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            this.btnAddTractor = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // btnAddTractor
            // 
            this.btnAddTractor.Location = new System.Drawing.Point(343, 381);
            this.btnAddTractor.Name = "btnAddTractor";
            this.btnAddTractor.Size = new System.Drawing.Size(90, 42);
            this.btnAddTractor.TabIndex = 0;
            this.btnAddTractor.Text = "Add Tractor";
            this.btnAddTractor.UseVisualStyleBackColor = true;
            this.btnAddTractor.Click += new System.EventHandler(this.btnAddTractor_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(32, 36);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "nodeBrand";
            treeNode1.Text = "Brand";
            treeNode2.Name = "nodeTractors";
            treeNode2.Text = "Tractors";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(732, 314);
            this.treeView1.TabIndex = 2;
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnAddTractor);
            this.Name = "MainForm";
            this.Text = "Farm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddTractor;
        private System.Windows.Forms.TreeView treeView1;
    }
}

