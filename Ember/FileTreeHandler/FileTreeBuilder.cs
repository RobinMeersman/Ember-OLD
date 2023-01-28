using System;
using System.IO;
using System.Windows.Forms;

namespace Ember
{
    // TODO: load tree in different thread to not block the ui
    public static class FileTreeHandler
    {
        private static void ProcessFiles(TreeNode root, DirectoryInfo start) 
        {
            foreach (FileInfo file in start.GetFiles())
            {
                TreeNode node = new TreeNode(file.Name);
                node.Tag = file;
                root.Nodes.Add(node);
            }
        }
        private static void ProcessDirs(TreeNode root, DirectoryInfo start) 
        {
            foreach (DirectoryInfo dir in start.GetDirectories())
            {
                TreeNode node = new TreeNode(dir.Name);
                node.Tag = dir;
                try
                {
                    if ((dir.Attributes & FileAttributes.NotContentIndexed) != FileAttributes.NotContentIndexed) // onzichtbaar, niet geindexeerde folder
                    {
                        ProcessDirs(node, dir);
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
        
        // main function of this class
        public static TreeNode LoadFileTree(string path)
        {
            DirectoryInfo start = new DirectoryInfo(path);
            TreeNode root = new TreeNode(start.Name);
            root.Tag = start;
            if (start.GetDirectories().Length == 0 && start.GetFiles().Length == 0) return root;
            if (start.GetDirectories().Length != 0)
            {
                ProcessDirs(root, start);
            }

            if (start.GetFiles().Length != 0)
            {
                ProcessFiles(root, start);
            }

            root.Expand();
            return root;
        }
    }
}