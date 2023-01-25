using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ember
{
    public partial class Main : Form
    {

        private ToolTip tp;
        public Main()
        {
            tp = new ToolTip();
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            StartPosition = FormStartPosition.CenterScreen;
            Properties.Settings.Default.images = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Properties.Settings.Default.documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Properties.Settings.Default.music = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Properties.Settings.Default.videos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            Properties.Settings.Default.desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            sizeL.Text = "";
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
                // todo
            }
        }

        private void desktopBtn_Click(object sender, EventArgs e)
        {
            LoadFileTree(Properties.Settings.Default.desktop);
        }

        private void imagesBtn_Click(object sender, EventArgs e)
        {
            LoadFileTree(Properties.Settings.Default.images);
        }

        private void documentsBtn_Click(object sender, EventArgs e)
        {
            LoadFileTree(Properties.Settings.Default.documents);
        }

        private void musicBtn_Click(object sender, EventArgs e)
        {
            LoadFileTree(Properties.Settings.Default.music);
        }

        private void videosBtn_Click(object sender, EventArgs e)
        {
            LoadFileTree(Properties.Settings.Default.videos);
        }

        private void LoadFileTree(string path)
        {
            fileTree.Nodes.Clear();
            DirectoryInfo start = new DirectoryInfo(path);
            TreeNode root = new TreeNode(start.Name);
            if (start.GetDirectories().Length == 0 && start.GetFiles().Length == 0) return;
            if (start.GetDirectories().Length != 0)
            {
                DirectoriesLoader(root, start);
            }

            if (start.GetFiles().Length != 0)
            {
                Files(root, start);
            }

            fileTree.Nodes.Add(root);
            root.Expand();
        }

        private void DirectoriesLoader(TreeNode root, DirectoryInfo start) 
        {
            foreach (DirectoryInfo dir in start.GetDirectories())
            {
                TreeNode node = new TreeNode(dir.Name);
                node.Tag = dir;
                try
                {
                    if ((dir.Attributes & FileAttributes.NotContentIndexed) != FileAttributes.NotContentIndexed) // onzichtbaar, niet geindexeerde folder
                    {
                        DirectoriesLoader(node, dir);
                        foreach (FileInfo f in dir.GetFiles())
                        {
                            TreeNode t = new TreeNode(f.Name);
                            t.Tag = f;
                            node.Nodes.Add(t);
                        }
                    }
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                root.Nodes.Add(node);
            }
        }
        private void Files(TreeNode root, DirectoryInfo start) 
        {
            foreach (FileInfo file in start.GetFiles())
            {
                root.Nodes.Add(new TreeNode(file.Name));
            }
        }

        private void fileTree_AfterSelect(object sender, TreeViewEventArgs e) // TODO: ERROR
        {
            TreeNode selected = fileTree.SelectedNode;
            if (selected.Nodes.Count > 0)
            {
                DirectoryInfo dir = (DirectoryInfo)selected.Tag;
                sizeL.Text = dir.EnumerateFiles().Sum(f => f.Length).ToString();
                return;
            }
            FileInfo fInfo = (FileInfo)selected.Tag;
            sizeL.Text = fInfo.Length.ToString();
        }

        private void fileTree_NodeMouseHover(object sender, TreeNodeMouseHoverEventArgs e)
        {
            TreeNode selected = fileTree.GetNodeAt(fileTree.PointToClient(Cursor.Position));
            if (selected == null) return;
            
            if (selected.Tag is FileInfo)
            {
                FileInfo f = (FileInfo)selected.Tag;
                tp.SetToolTip(fileTree, f.FullName);
            }
            else
            {
                DirectoryInfo d = (DirectoryInfo)selected.Tag;
                tp.SetToolTip(fileTree, d.FullName);
            }
        }
    }
}