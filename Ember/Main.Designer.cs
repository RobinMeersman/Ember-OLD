using System.ComponentModel;

namespace Ember
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.leftBar = new System.Windows.Forms.Panel();
            this.videosBtn = new System.Windows.Forms.Button();
            this.musicBtn = new System.Windows.Forms.Button();
            this.documentsBtn = new System.Windows.Forms.Button();
            this.imagesBtn = new System.Windows.Forms.Button();
            this.desktopBtn = new System.Windows.Forms.Button();
            this.leftTitle = new System.Windows.Forms.Label();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.fileTree = new System.Windows.Forms.TreeView();
            this.leftBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 0;
            // 
            // leftBar
            // 
            this.leftBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left)));
            this.leftBar.BackColor = System.Drawing.Color.Transparent;
            this.leftBar.Controls.Add(this.videosBtn);
            this.leftBar.Controls.Add(this.musicBtn);
            this.leftBar.Controls.Add(this.documentsBtn);
            this.leftBar.Controls.Add(this.imagesBtn);
            this.leftBar.Controls.Add(this.desktopBtn);
            this.leftBar.Controls.Add(this.leftTitle);
            this.leftBar.Location = new System.Drawing.Point(3, 12);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(201, 561);
            this.leftBar.TabIndex = 0;
            this.leftBar.Paint += new System.Windows.Forms.PaintEventHandler(this.leftBar_Paint);
            // 
            // videosBtn
            // 
            this.videosBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.videosBtn.Location = new System.Drawing.Point(20, 408);
            this.videosBtn.Name = "videosBtn";
            this.videosBtn.Size = new System.Drawing.Size(163, 29);
            this.videosBtn.TabIndex = 5;
            this.videosBtn.Text = "Video";
            this.videosBtn.UseVisualStyleBackColor = true;
            // 
            // musicBtn
            // 
            this.musicBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.musicBtn.Location = new System.Drawing.Point(20, 332);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(163, 37);
            this.musicBtn.TabIndex = 4;
            this.musicBtn.Text = "Music";
            this.musicBtn.UseVisualStyleBackColor = true;
            // 
            // documentsBtn
            // 
            this.documentsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.documentsBtn.Location = new System.Drawing.Point(20, 268);
            this.documentsBtn.Name = "documentsBtn";
            this.documentsBtn.Size = new System.Drawing.Size(162, 31);
            this.documentsBtn.TabIndex = 3;
            this.documentsBtn.Text = "Documents";
            this.documentsBtn.UseVisualStyleBackColor = true;
            // 
            // imagesBtn
            // 
            this.imagesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imagesBtn.Location = new System.Drawing.Point(20, 202);
            this.imagesBtn.Name = "imagesBtn";
            this.imagesBtn.Size = new System.Drawing.Size(162, 31);
            this.imagesBtn.TabIndex = 2;
            this.imagesBtn.Text = "Images";
            this.imagesBtn.UseVisualStyleBackColor = true;
            // 
            // desktopBtn
            // 
            this.desktopBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.desktopBtn.Location = new System.Drawing.Point(18, 141);
            this.desktopBtn.Name = "desktopBtn";
            this.desktopBtn.Size = new System.Drawing.Size(164, 32);
            this.desktopBtn.TabIndex = 1;
            this.desktopBtn.Text = "Desktop";
            this.desktopBtn.UseVisualStyleBackColor = true;
            // 
            // leftTitle
            // 
            this.leftTitle.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.leftTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftTitle.Location = new System.Drawing.Point(12, 9);
            this.leftTitle.Name = "leftTitle";
            this.leftTitle.Size = new System.Drawing.Size(171, 33);
            this.leftTitle.TabIndex = 0;
            this.leftTitle.Text = "Shortcuts       ";
            this.leftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Location = new System.Drawing.Point(12, 572);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1026, 36);
            this.infoPanel.TabIndex = 1;
            this.infoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fileTree.Location = new System.Drawing.Point(210, 12);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(827, 554);
            this.fileTree.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1050, 608);
            this.Controls.Add(this.fileTree);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.leftBar);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Main";
            this.Text = "Ember Filemanager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.leftBar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView fileTree;

        private System.Windows.Forms.Button desktopBtn;
        private System.Windows.Forms.Button imagesBtn;
        private System.Windows.Forms.Button documentsBtn;
        private System.Windows.Forms.Button musicBtn;
        private System.Windows.Forms.Button videosBtn;

        private System.Windows.Forms.Panel infoPanel;

        private System.Windows.Forms.Label leftTitle;

        private System.Windows.Forms.Panel leftBar;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}