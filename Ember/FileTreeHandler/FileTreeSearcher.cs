using System.Windows.Forms;

namespace Ember.FileTreeHandler
{
    public static class FileTreeSearcher
    {
        // to implement: searcher to find Node with file/folder for given input
        public static void Search(TreeNode root, string name, TreeView tree)
        {
            if (root.Text == name)
            {
                // replaceTree(tree, root);
                root.Expand();
                return;
            }
            
            // replaceTree(tree, searchRecurse(root, name));
            TreeNode node = searchRecurse(root, name);
            if (node != null)
            {
                node.Expand();
                TreeNode parent = node.Parent;
                while (parent != null)
                {
                    parent.Expand();
                    parent = parent.Parent;
                }

                tree.SelectedNode = node;
            }
        }
        private static void replaceTree(TreeView tree, TreeNode root)
        {
            if (root == null) return;
            tree.Nodes.Clear();
            tree.Nodes.Add(root);
        }

        private static TreeNode searchRecurse(TreeNode root, string name)
        {
            if (root.Text == name) return root;
            foreach (TreeNode child in root.Nodes)
            {
                if (child.Text == name) return child;
                TreeNode node = searchRecurse(child, name);
                if (node != null && node.Text == name) return node;
            }
            return null;
        }
    }
}