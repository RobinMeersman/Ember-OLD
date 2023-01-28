using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ember
{
    public partial class Main : Form
    {

        private ToolTip tp;
        private Dictionary<Button, string> paths;
        public Main()
        {
            tp = new ToolTip();
            InitializeComponent();
            paths = new Dictionary<Button, string>();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            sizeL.Text = "";
            sizeL.AutoSize = true;

            paths[desktopBtn] = Properties.Settings.Default.desktop;
            paths[imagesBtn] = Properties.Settings.Default.images;
            paths[musicBtn] = Properties.Settings.Default.music;
            paths[videosBtn] = Properties.Settings.Default.videos;
            paths[documentsBtn] = Properties.Settings.Default.documents;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            fileTree.Nodes.Clear();
            Button btn = sender as Button;
            fileTree.Nodes.Add(FileTreeHandler.LoadFileTree(paths[btn]));
        }

        private void leftBar_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, 
                Color.Transparent, 0, ButtonBorderStyle.None,
                Color.Transparent, 0, ButtonBorderStyle.None,
                Color.Orange, 2, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.None
                );
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, 
                Color.Transparent, 0, ButtonBorderStyle.None,
                Color.Orange, 2, ButtonBorderStyle.Solid,
                Color.Transparent, 0, ButtonBorderStyle.None,
                Color.Transparent, 0, ButtonBorderStyle.None
            );
        }

        private void searchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // todo: implement
            }
        }

        private void fileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = fileTree.SelectedNode;
            if (selected.Tag is DirectoryInfo)
            {
                DirectoryInfo dir = selected.Tag as DirectoryInfo;
                sizeL.Text = dir.EnumerateFiles().Sum(f => f.Length).ToString();
                return;
            }
            FileInfo fInfo = selected.Tag as FileInfo;
            sizeL.Text = fInfo.Length.ToString();
        }
        
        // todo: fix timing: becomes visible way to fast (low priority)
        private void fileTree_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            // TreeNode selected = fileTree.GetNodeAt(fileTree.PointToClient(Cursor.Position));
            // if (selected == null) return;
            //
            // if (selected.Tag is FileInfo)
            // {
            //     FileInfo f = (FileInfo)selected.Tag;
            //     tp.SetToolTip(fileTree, f.FullName);
            // }
            // else
            // {
            //     DirectoryInfo d = (DirectoryInfo)selected.Tag;
            //     tp.SetToolTip(fileTree, d.FullName);
            // }
        }

        private void fileTree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
        }
    }
}