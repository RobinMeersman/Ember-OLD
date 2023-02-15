using System.Windows.Forms;

namespace Ember.FileTreeHandler
{
    public static class FileTreeSearcher
    {
        public static void Search(TreeNode root, string name, TreeView tree)
        {
            TreeNode node = SearchRecurse(root, name);
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

        private static TreeNode SearchRecurse(TreeNode root, string name)
        {
            if (root.Text == name) return root;
            foreach (TreeNode child in root.Nodes)
            {
                if (child.Text == name) return child;
                TreeNode node = SearchRecurse(child, name);
                if (node != null && node.Text == name) return node;
            }
            return null;
        }
    }
}