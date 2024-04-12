namespace ST02_2_1071_Miron_Alin
{
    partial class AddEditForm
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
            this.lblBookTitle = new System.Windows.Forms.Label();
            this.lblBookPages = new System.Windows.Forms.Label();
            this.lblBookReleaseDate = new System.Windows.Forms.Label();
            this.tbBookTitle = new System.Windows.Forms.TextBox();
            this.nudBookPages = new System.Windows.Forms.NumericUpDown();
            this.dtpBookReleaseDate = new System.Windows.Forms.DateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.epBookTitile = new System.Windows.Forms.ErrorProvider(this.components);
            this.epBookPages = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudBookPages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBookTitile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBookPages)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBookTitle
            // 
            this.lblBookTitle.AutoSize = true;
            this.lblBookTitle.Location = new System.Drawing.Point(27, 30);
            this.lblBookTitle.Name = "lblBookTitle";
            this.lblBookTitle.Size = new System.Drawing.Size(55, 13);
            this.lblBookTitle.TabIndex = 0;
            this.lblBookTitle.Text = "Book Title";
            // 
            // lblBookPages
            // 
            this.lblBookPages.AutoSize = true;
            this.lblBookPages.Location = new System.Drawing.Point(27, 80);
            this.lblBookPages.Name = "lblBookPages";
            this.lblBookPages.Size = new System.Drawing.Size(65, 13);
            this.lblBookPages.TabIndex = 1;
            this.lblBookPages.Text = "Book Pages";
            // 
            // lblBookReleaseDate
            // 
            this.lblBookReleaseDate.AutoSize = true;
            this.lblBookReleaseDate.Location = new System.Drawing.Point(27, 132);
            this.lblBookReleaseDate.Name = "lblBookReleaseDate";
            this.lblBookReleaseDate.Size = new System.Drawing.Size(100, 13);
            this.lblBookReleaseDate.TabIndex = 2;
            this.lblBookReleaseDate.Text = "Book Release Date";
            // 
            // tbBookTitle
            // 
            this.tbBookTitle.Location = new System.Drawing.Point(141, 27);
            this.tbBookTitle.Name = "tbBookTitle";
            this.tbBookTitle.Size = new System.Drawing.Size(211, 20);
            this.tbBookTitle.TabIndex = 3;
            this.tbBookTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbBookTitle_Validating);
            this.tbBookTitle.Validated += new System.EventHandler(this.tbBookTitle_Validated);
            // 
            // nudBookPages
            // 
            this.nudBookPages.Location = new System.Drawing.Point(141, 78);
            this.nudBookPages.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudBookPages.Name = "nudBookPages";
            this.nudBookPages.Size = new System.Drawing.Size(211, 20);
            this.nudBookPages.TabIndex = 4;
            this.nudBookPages.Validating += new System.ComponentModel.CancelEventHandler(this.nudBookPages_Validating);
            this.nudBookPages.Validated += new System.EventHandler(this.nudBookPages_Validated);
            // 
            // dtpBookReleaseDate
            // 
            this.dtpBookReleaseDate.Location = new System.Drawing.Point(141, 127);
            this.dtpBookReleaseDate.Name = "dtpBookReleaseDate";
            this.dtpBookReleaseDate.Size = new System.Drawing.Size(211, 20);
            this.dtpBookReleaseDate.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(30, 188);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(104, 36);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(248, 188);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 36);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // epBookTitile
            // 
            this.epBookTitile.ContainerControl = this;
            // 
            // epBookPages
            // 
            this.epBookPages.ContainerControl = this;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 245);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtpBookReleaseDate);
            this.Controls.Add(this.nudBookPages);
            this.Controls.Add(this.tbBookTitle);
            this.Controls.Add(this.lblBookReleaseDate);
            this.Controls.Add(this.lblBookPages);
            this.Controls.Add(this.lblBookTitle);
            this.Name = "AddEditForm";
            this.Text = "AddEditForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudBookPages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBookTitile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epBookPages)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBookTitle;
        private System.Windows.Forms.Label lblBookPages;
        private System.Windows.Forms.Label lblBookReleaseDate;
        private System.Windows.Forms.TextBox tbBookTitle;
        private System.Windows.Forms.NumericUpDown nudBookPages;
        private System.Windows.Forms.DateTimePicker dtpBookReleaseDate;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider epBookTitile;
        private System.Windows.Forms.ErrorProvider epBookPages;
    }
}