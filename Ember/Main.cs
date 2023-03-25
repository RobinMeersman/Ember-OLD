using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Ember.FileTreeHandler;

namespace Ember
{
    // TODO: add splash screen at startup to wanted features
    public partial class Main : Form
    {

        private ToolTip _tp;
        private Dictionary<Button, string> _paths;
        private TreeNode root;
        public Main()
        {
            _tp = new ToolTip();
            InitializeComponent();
            _paths = new Dictionary<Button, string>();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // todo: not quit there yet :thinking:
            StartPosition = FormStartPosition.Manual;
            Location = new Point(Screen.PrimaryScreen.Bounds.X, Screen.PrimaryScreen.Bounds.Y);
            sizeL.Text = "";
            Width = Screen.PrimaryScreen.WorkingArea.Width;
            Height = Screen.PrimaryScreen.WorkingArea.Height;
            sizeL.AutoSize = false;

            _paths[desktopBtn] = Properties.Settings.Default.desktop;
            _paths[imagesBtn] = Properties.Settings.Default.images;
            _paths[musicBtn] = Properties.Settings.Default.music;
            _paths[videosBtn] = Properties.Settings.Default.videos;
            _paths[documentsBtn] = Properties.Settings.Default.documents;
        }

        private void ClickHandler(object sender, EventArgs e)
        {
            fileTree.Nodes.Clear();
            Button btn = sender as Button;
            fileTree.Nodes.Add(FileTreeBuilder.LoadFileTree(_paths[btn]));
            root = fileTree.Nodes[0];
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
            if (e.KeyCode == Keys.Enter && root != null)
            {
                FileTreeSearcher.Search(root, searchBox.Text, fileTree);
            }
        }

        private void fileTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeNode selected = fileTree.SelectedNode;
            FileDir fD = selected.Tag as FileDir;
            if (fD.getFileDirObject() is DirectoryInfo || fD.getFileDirObject() is FileInfo)
            {
                // DirectoryInfo dir = selected.Tag as DirectoryInfo;
                // long size = dir.EnumerateFiles().Sum(f => f.Length);
                long size = fD.getSize();
                int i = 0;
                string[] units = { "B", "KB", "MB", "GB", "TB" };
                while (size > 1000)
                {
                    i++;
                    size /= 1000;
                }

                if (i > units.Length - 1) i = units.Length - 1;
                sizeL.Text = $"{(float) size}{units[i]}";
            }
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
            rightClick menu = new rightClick(fileTree.SelectedNode.Tag as FileDir);
            if (e.Button == MouseButtons.Right)
            {
                menu.SetDesktopLocation(Cursor.Position.X, Cursor.Position.Y);
                menu.Show(this);
                return;
            }

            if (e.Button == MouseButtons.Left && !menu.withinBounds(Cursor.Position))
            {
                menu.CloseSelf();
            }
        }

        private void fileTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeNode node = fileTree.SelectedNode;
            FileDir fD = node.Tag as FileDir;
            if (fD.getFileDirObject() is FileInfo)
            {
                // todo: use runner to start app with selected file
            }
        }
    }
}