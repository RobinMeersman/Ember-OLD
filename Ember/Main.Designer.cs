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
            this.sizeL = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fileTree = new System.Windows.Forms.TreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.searchBox = new System.Windows.Forms.TextBox();
            this.leftBar.SuspendLayout();
            this.infoPanel.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.leftBar.Location = new System.Drawing.Point(4, 15);
            this.leftBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.leftBar.Name = "leftBar";
            this.leftBar.Size = new System.Drawing.Size(268, 690);
            this.leftBar.TabIndex = 0;
            this.leftBar.Paint += new System.Windows.Forms.PaintEventHandler(this.leftBar_Paint);
            // 
            // videosBtn
            // 
            this.videosBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.videosBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.videosBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.videosBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.videosBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.videosBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.videosBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.videosBtn.Location = new System.Drawing.Point(0, 459);
            this.videosBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.videosBtn.Name = "videosBtn";
            this.videosBtn.Size = new System.Drawing.Size(264, 39);
            this.videosBtn.TabIndex = 5;
            this.videosBtn.Text = "Video";
            this.videosBtn.UseVisualStyleBackColor = true;
            this.videosBtn.Click += new System.EventHandler(this.ClickHandler);
            // 
            // musicBtn
            // 
            this.musicBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.musicBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.musicBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.musicBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.musicBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.musicBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musicBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.musicBtn.Location = new System.Drawing.Point(0, 393);
            this.musicBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.musicBtn.Name = "musicBtn";
            this.musicBtn.Size = new System.Drawing.Size(264, 39);
            this.musicBtn.TabIndex = 4;
            this.musicBtn.Text = "Music";
            this.musicBtn.UseVisualStyleBackColor = false;
            this.musicBtn.Click += new System.EventHandler(this.ClickHandler);
            // 
            // documentsBtn
            // 
            this.documentsBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.documentsBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.documentsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.documentsBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.documentsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.documentsBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.documentsBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.documentsBtn.Location = new System.Drawing.Point(0, 327);
            this.documentsBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.documentsBtn.Name = "documentsBtn";
            this.documentsBtn.Size = new System.Drawing.Size(264, 39);
            this.documentsBtn.TabIndex = 3;
            this.documentsBtn.Text = "Documents";
            this.documentsBtn.UseVisualStyleBackColor = true;
            this.documentsBtn.Click += new System.EventHandler(this.ClickHandler);
            // 
            // imagesBtn
            // 
            this.imagesBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.imagesBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.imagesBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.imagesBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.imagesBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.imagesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imagesBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.imagesBtn.Location = new System.Drawing.Point(0, 263);
            this.imagesBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.imagesBtn.Name = "imagesBtn";
            this.imagesBtn.Size = new System.Drawing.Size(264, 39);
            this.imagesBtn.TabIndex = 2;
            this.imagesBtn.Text = "Images";
            this.imagesBtn.UseVisualStyleBackColor = true;
            this.imagesBtn.Click += new System.EventHandler(this.ClickHandler);
            // 
            // desktopBtn
            // 
            this.desktopBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.desktopBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.desktopBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.desktopBtn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.desktopBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.desktopBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.desktopBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.desktopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desktopBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.desktopBtn.Location = new System.Drawing.Point(0, 201);
            this.desktopBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.desktopBtn.Name = "desktopBtn";
            this.desktopBtn.Size = new System.Drawing.Size(264, 39);
            this.desktopBtn.TabIndex = 1;
            this.desktopBtn.Text = "Desktop";
            this.desktopBtn.UseVisualStyleBackColor = false;
            this.desktopBtn.Click += new System.EventHandler(this.ClickHandler);
            // 
            // leftTitle
            // 
            this.leftTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(97)))), ((int)(((byte)(0)))));
            this.leftTitle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.leftTitle.Location = new System.Drawing.Point(0, 0);
            this.leftTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.leftTitle.Name = "leftTitle";
            this.leftTitle.Size = new System.Drawing.Size(243, 41);
            this.leftTitle.TabIndex = 0;
            this.leftTitle.Text = "Shortcuts       ";
            this.leftTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // infoPanel
            // 
            this.infoPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.infoPanel.BackColor = System.Drawing.Color.Transparent;
            this.infoPanel.Controls.Add(this.sizeL);
            this.infoPanel.Controls.Add(this.label2);
            this.infoPanel.Location = new System.Drawing.Point(16, 704);
            this.infoPanel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(1368, 44);
            this.infoPanel.TabIndex = 1;
            this.infoPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // sizeL
            // 
            this.sizeL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sizeL.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sizeL.Location = new System.Drawing.Point(79, 6);
            this.sizeL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sizeL.Name = "sizeL";
            this.sizeL.Size = new System.Drawing.Size(177, 31);
            this.sizeL.TabIndex = 1;
            this.sizeL.Text = "3";
            this.sizeL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.sizeL.UseMnemonic = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 5);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "size:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // fileTree
            // 
            this.fileTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.fileTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.fileTree.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fileTree.Location = new System.Drawing.Point(280, 65);
            this.fileTree.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fileTree.Name = "fileTree";
            this.fileTree.Size = new System.Drawing.Size(1101, 630);
            this.fileTree.TabIndex = 2;
            this.fileTree.NodeMouseHover += new System.Windows.Forms.TreeNodeMouseHoverEventHandler(this.fileTree_NodeMouseHover);
            this.fileTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.fileTree_AfterSelect);
            this.fileTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.fileTree_MouseClick);
            this.fileTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.fileTree_MouseDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.searchBox);
            this.panel1.Location = new System.Drawing.Point(280, 18);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1101, 36);
            this.panel1.TabIndex = 3;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Right)));
            this.searchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.searchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchBox.Location = new System.Drawing.Point(560, 4);
            this.searchBox.Margin = new System.Windows.Forms.Padding(0);
            this.searchBox.Name = "searchBox";
            this.searchBox.Size = new System.Drawing.Size(541, 15);
            this.searchBox.TabIndex = 0;
            this.searchBox.Text = "Search";
            this.searchBox.WordWrap = false;
            this.searchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchBox_KeyDown);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(78)))), ((int)(((byte)(78)))));
            this.ClientSize = new System.Drawing.Size(1400, 748);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.fileTree);
            this.Controls.Add(this.infoPanel);
            this.Controls.Add(this.leftBar);
            this.Location = new System.Drawing.Point(15, 15);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Ember Filemanager";
            this.Load += new System.EventHandler(this.Main_Load);
            this.leftBar.ResumeLayout(false);
            this.infoPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox searchBox;

        private System.Windows.Forms.Label sizeL;

        private System.Windows.Forms.Label label2;

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