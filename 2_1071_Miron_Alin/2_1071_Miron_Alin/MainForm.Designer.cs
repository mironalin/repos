namespace _2_1071_Miron_Alin
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
            this.components = new System.ComponentModel.Container();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lvWaiters = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTablesServed = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colStartTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 394);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(98, 44);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add Waiter";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lvWaiters
            // 
            this.lvWaiters.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colTablesServed,
            this.colStartTime});
            this.lvWaiters.FullRowSelect = true;
            this.lvWaiters.HideSelection = false;
            this.lvWaiters.Location = new System.Drawing.Point(12, 37);
            this.lvWaiters.Name = "lvWaiters";
            this.lvWaiters.Size = new System.Drawing.Size(776, 333);
            this.lvWaiters.TabIndex = 1;
            this.lvWaiters.UseCompatibleStateImageBehavior = false;
            this.lvWaiters.View = System.Windows.Forms.View.Details;
            this.lvWaiters.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvWaiters_MouseDoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 174;
            // 
            // colTablesServed
            // 
            this.colTablesServed.Text = "Tables Served";
            this.colTablesServed.Width = 268;
            // 
            // colStartTime
            // 
            this.colStartTime.Text = "Start Time";
            this.colStartTime.Width = 324;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeXMLToolStripMenuItem,
            this.deserializeXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(154, 48);
            // 
            // serializeXMLToolStripMenuItem
            // 
            this.serializeXMLToolStripMenuItem.Name = "serializeXMLToolStripMenuItem";
            this.serializeXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serializeXMLToolStripMenuItem.Text = "SerializeXML";
            this.serializeXMLToolStripMenuItem.Click += new System.EventHandler(this.serializeXMLToolStripMenuItem_Click);
            // 
            // deserializeXMLToolStripMenuItem
            // 
            this.deserializeXMLToolStripMenuItem.Name = "deserializeXMLToolStripMenuItem";
            this.deserializeXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deserializeXMLToolStripMenuItem.Text = "DeserializeXML";
            this.deserializeXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializeXMLToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lvWaiters);
            this.Controls.Add(this.btnAdd);
            this.Name = "MainForm";
            this.Text = "Restaurant";
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ListView lvWaiters;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colTablesServed;
        private System.Windows.Forms.ColumnHeader colStartTime;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem serializeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeXMLToolStripMenuItem;
    }
}

