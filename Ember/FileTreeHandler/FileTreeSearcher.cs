using System.Windows.Forms;

namespace Ember.FileTreeHandler
{
    public static class FileTreeSearcher
    {
        public static void Search(TreeNode root, string name, TreeView tree)
        {
            // todo: maybe convert recursive function to iterative (big fileSystems can cause stackoverflow error)
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
        private static void ReplaceTree(TreeView tree, TreeNode root)
        {
            if (root == null) return;
            tree.Nodes.Clear();
            tree.Nodes.Add(root);
        }

        public static TreeNode TestSearch(TreeNode root, string name)
        {
            return SearchRecurse(root, name);
        }

        private static TreeNode SearchRecurse(TreeNode root, string name)
        {
            if (root == null || name == "") return null;
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