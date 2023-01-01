using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Ember
{
    public partial class Main : Form
    {
        public Main()
        {
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
                directories(root, start);
            }

            if (start.GetFiles().Length != 0)
            {
                files(root, start);
            }

            fileTree.Nodes.Add(root);
            root.Expand();
        }

        private void directories(TreeNode root, DirectoryInfo start) 
        {
            foreach (DirectoryInfo dir in start.GetDirectories())
            {
                TreeNode node = new TreeNode(dir.Name);
                try
                {
                    if ((dir.Attributes & FileAttributes.NotContentIndexed) != FileAttributes.NotContentIndexed)
                    {
                        directories(node, dir);
                        foreach (FileInfo f in dir.GetFiles())
                        {
                            node.Nodes.Add(f.Name);
                        }
                        
                        foreach (FileInfo file in dir.GetFiles())
                        {
                            node.Nodes.Add(file.Name);
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
        private void files(TreeNode root, DirectoryInfo start) 
        {
            foreach (FileInfo file in start.GetFiles())
            {
                root.Nodes.Add(new TreeNode(file.Name));
            }
        }
    }
}