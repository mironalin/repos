namespace ST02_2_1071_Miron_Alin
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
            this.btnAddBook = new System.Windows.Forms.Button();
            this.lvLibary = new System.Windows.Forms.ListView();
            this.colBookTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookPage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colBookReleaseDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmsLibrary = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeBinaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmsLibrary.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(26, 381);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(88, 45);
            this.btnAddBook.TabIndex = 0;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // lvLibary
            // 
            this.lvLibary.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colBookTitle,
            this.colBookPage,
            this.colBookReleaseDate});
            this.lvLibary.FullRowSelect = true;
            this.lvLibary.HideSelection = false;
            this.lvLibary.Location = new System.Drawing.Point(26, 34);
            this.lvLibary.Name = "lvLibary";
            this.lvLibary.Size = new System.Drawing.Size(750, 297);
            this.lvLibary.TabIndex = 1;
            this.lvLibary.UseCompatibleStateImageBehavior = false;
            this.lvLibary.View = System.Windows.Forms.View.Details;
            this.lvLibary.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvLibrary_MouseDoubleClick);
            // 
            // colBookTitle
            // 
            this.colBookTitle.Text = "Book Title";
            this.colBookTitle.Width = 201;
            // 
            // colBookPage
            // 
            this.colBookPage.Text = "Book Pages";
            this.colBookPage.Width = 244;
            // 
            // colBookReleaseDate
            // 
            this.colBookReleaseDate.Text = "Book Release Date";
            this.colBookReleaseDate.Width = 294;
            // 
            // cmsLibrary
            // 
            this.cmsLibrary.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeBinaryToolStripMenuItem,
            this.deserializeBinaryToolStripMenuItem});
            this.cmsLibrary.Name = "cmsLibrary";
            this.cmsLibrary.Size = new System.Drawing.Size(181, 70);
            // 
            // serializeBinaryToolStripMenuItem
            // 
            this.serializeBinaryToolStripMenuItem.Name = "serializeBinaryToolStripMenuItem";
            this.serializeBinaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.serializeBinaryToolStripMenuItem.Text = "SerializeBinary";
            this.serializeBinaryToolStripMenuItem.Click += new System.EventHandler(this.serializeBinaryToolStripMenuItem_Click);
            // 
            // deserializeBinaryToolStripMenuItem
            // 
            this.deserializeBinaryToolStripMenuItem.Name = "deserializeBinaryToolStripMenuItem";
            this.deserializeBinaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deserializeBinaryToolStripMenuItem.Text = "DeserializeBinary";
            this.deserializeBinaryToolStripMenuItem.Click += new System.EventHandler(this.deserializeBinaryToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ContextMenuStrip = this.cmsLibrary;
            this.Controls.Add(this.lvLibary);
            this.Controls.Add(this.btnAddBook);
            this.Name = "MainForm";
            this.Text = "Library";
            this.cmsLibrary.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ListView lvLibary;
        private System.Windows.Forms.ColumnHeader colBookTitle;
        private System.Windows.Forms.ColumnHeader colBookPage;
        private System.Windows.Forms.ColumnHeader colBookReleaseDate;
        private System.Windows.Forms.ContextMenuStrip cmsLibrary;
        private System.Windows.Forms.ToolStripMenuItem serializeBinaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeBinaryToolStripMenuItem;
    }
}

