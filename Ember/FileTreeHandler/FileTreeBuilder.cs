using System;
using System.IO;
using System.Windows.Forms;

namespace Ember.FileTreeHandler
{
    // TODO: load tree in different thread to not block the ui
    public static class FileTreeBuilder
    {
        private static long ProcessFiles(TreeNode root, DirectoryInfo start)
        {
            long size = 0;
            foreach (FileInfo file in start.GetFiles())
            {
                TreeNode node = new TreeNode(file.Name);
                node.Tag = new FileDir(file.Length, file);
                root.Nodes.Add(node);
                size += file.Length;
            }

            return size;
        }
        private static long ProcessDirs(TreeNode root, DirectoryInfo start)
        {
            long size = 0;
            foreach (DirectoryInfo dir in start.GetDirectories())
            {
                long sum = 0;
                TreeNode node = new TreeNode(dir.Name);
                try
                {
                    if ((dir.Attributes & FileAttributes.NotContentIndexed) != FileAttributes.NotContentIndexed) // onzichtbaar, niet geindexeerde folder
                    {
                        sum += ProcessDirs(node, dir);
                        foreach (FileInfo f in dir.GetFiles())
                        {
                            TreeNode t = new TreeNode(f.Name);
                            t.Tag = new FileDir(f.Length, f);
                            sum += f.Length;
                            node.Nodes.Add(t);
                        }
                    }
                    node.Tag = new FileDir(sum, dir);
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                root.Nodes.Add(node);
                size += sum;
            }
            return size;
        }
        
        // main function of this class
        public static TreeNode LoadFileTree(string path)
        {
            DirectoryInfo start = new DirectoryInfo(path);
            TreeNode root = new TreeNode(start.Name);
            long size = 0;
            if (start.GetDirectories().Length == 0 && start.GetFiles().Length == 0) return root;
            if (start.GetDirectories().Length != 0)
            {
                size += ProcessDirs(root, start);
            }

            if (start.GetFiles().Length != 0)
            {
                size += ProcessFiles(root, start);
            }

            root.Tag = new FileDir(size, start);
            root.Expand();
            return root;
        }
    }
}