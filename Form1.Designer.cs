namespace Symlinker
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
            this.InputFrom = new System.Windows.Forms.TextBox();
            this.BrowseFrom = new System.Windows.Forms.Button();
            this.FileDialogTo = new System.Windows.Forms.SaveFileDialog();
            this.BrowseTo = new System.Windows.Forms.Button();
            this.InputTo = new System.Windows.Forms.TextBox();
            this.Proceed = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.FolderDialogFrom = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // InputFrom
            // 
            this.InputFrom.Location = new System.Drawing.Point(12, 32);
            this.InputFrom.Name = "InputFrom";
            this.InputFrom.Size = new System.Drawing.Size(219, 20);
            this.InputFrom.TabIndex = 0;
            // 
            // BrowseFrom
            // 
            this.BrowseFrom.Location = new System.Drawing.Point(228, 30);
            this.BrowseFrom.Name = "BrowseFrom";
            this.BrowseFrom.Size = new System.Drawing.Size(25, 23);
            this.BrowseFrom.TabIndex = 1;
            this.BrowseFrom.Text = "...";
            this.BrowseFrom.UseVisualStyleBackColor = true;
            this.BrowseFrom.Click += new System.EventHandler(this.button1_Click);
            // 
            // BrowseTo
            // 
            this.BrowseTo.Location = new System.Drawing.Point(228, 75);
            this.BrowseTo.Name = "BrowseTo";
            this.BrowseTo.Size = new System.Drawing.Size(25, 23);
            this.BrowseTo.TabIndex = 3;
            this.BrowseTo.Text = "...";
            this.BrowseTo.UseVisualStyleBackColor = true;
            this.BrowseTo.Click += new System.EventHandler(this.BrowseTo_Click);
            // 
            // InputTo
            // 
            this.InputTo.Location = new System.Drawing.Point(12, 77);
            this.InputTo.Name = "InputTo";
            this.InputTo.Size = new System.Drawing.Size(219, 20);
            this.InputTo.TabIndex = 2;
            // 
            // Proceed
            // 
            this.Proceed.Location = new System.Drawing.Point(219, 129);
            this.Proceed.Name = "Proceed";
            this.Proceed.Size = new System.Drawing.Size(60, 23);
            this.Proceed.TabIndex = 4;
            this.Proceed.Text = "Proceed";
            this.Proceed.UseVisualStyleBackColor = true;
            this.Proceed.Click += new System.EventHandler(this.Proceed_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 164);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Proceed);
            this.Controls.Add(this.BrowseTo);
            this.Controls.Add(this.InputTo);
            this.Controls.Add(this.BrowseFrom);
            this.Controls.Add(this.InputFrom);
            this.Name = "MainForm";
            this.Text = "Symlink it !";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox InputFrom;
        private System.Windows.Forms.Button BrowseFrom;
        private System.Windows.Forms.SaveFileDialog FileDialogTo;
        private System.Windows.Forms.Button BrowseTo;
        private System.Windows.Forms.TextBox InputTo;
        private System.Windows.Forms.Button Proceed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FolderBrowserDialog FolderDialogFrom;
    }
}

