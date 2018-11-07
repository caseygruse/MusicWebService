namespace MusicWebService
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtArtistName = new System.Windows.Forms.TextBox();
            this.txtSongTitle = new System.Windows.Forms.TextBox();
            this.txtLyrics = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Artist Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Song Title";
            // 
            // txtArtistName
            // 
            this.txtArtistName.Location = new System.Drawing.Point(379, 78);
            this.txtArtistName.Name = "txtArtistName";
            this.txtArtistName.Size = new System.Drawing.Size(100, 20);
            this.txtArtistName.TabIndex = 2;
            // 
            // txtSongTitle
            // 
            this.txtSongTitle.Location = new System.Drawing.Point(379, 126);
            this.txtSongTitle.Name = "txtSongTitle";
            this.txtSongTitle.Size = new System.Drawing.Size(100, 20);
            this.txtSongTitle.TabIndex = 3;
            // 
            // txtLyrics
            // 
            this.txtLyrics.Location = new System.Drawing.Point(12, 224);
            this.txtLyrics.Multiline = true;
            this.txtLyrics.Name = "txtLyrics";
            this.txtLyrics.ReadOnly = true;
            this.txtLyrics.Size = new System.Drawing.Size(776, 214);
            this.txtLyrics.TabIndex = 4;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(303, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 39);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtLyrics);
            this.Controls.Add(this.txtSongTitle);
            this.Controls.Add(this.txtArtistName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtArtistName;
        private System.Windows.Forms.TextBox txtSongTitle;
        private System.Windows.Forms.TextBox txtLyrics;
        private System.Windows.Forms.Button btnSearch;
    }
}

