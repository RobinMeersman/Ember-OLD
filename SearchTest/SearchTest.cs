using System;
using System.Windows.Forms;
using NUnit.Framework;
using Ember.FileTreeHandler;
using NUnit.Framework.Interfaces;

namespace SearchTest
{
    [TestFixture]
    public class Tests
    {
        private TreeNode root = BuildTree();

        private static TreeNode BuildTree()
        {
            TreeNode root = new TreeNode();
            root.Text = "root";

            for (int i = 0; i < 10; ++i)
            {
                root.Nodes.Add(new TreeNode(i.ToString()));
                for (int j = 0; j < 10; ++j)
                {
                    root.Nodes[i].Nodes.Add(new TreeNode(i.ToString() + j));
                }
            }
            return root;
        }
        
        [Test]
        public void TestSearchRoot()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "root");
            Assert.AreEqual("root", found.Text);
        }

        [Test]
        public void TestSearch1()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "79");
            Assert.AreEqual("79", found.Text);
        }
        
        [Test]
        public void TestSearch2()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "33");
            Assert.AreEqual("33", found.Text);
        }
        
        [Test]
        public void TestSearch3()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "29");
            Assert.AreEqual("29", found.Text);
        }
        
        [Test]
        public void TestSearch4()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "3");
            Assert.AreEqual("3", found.Text);
        }

        [Test]
        public void TestNotFound1()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "100");
            Assert.IsNull(found);
        }
        
        [Test]
        public void TestNotFound2()
        {
            TreeNode found = FileTreeSearcher.TestSearch(root, "");
            Assert.IsNull(found);
        }
        
        [Test]
        public void TestNotFound3()
        {
            TreeNode found = FileTreeSearcher.TestSearch(null, "12");
            Assert.IsNull(found);
        }
    }
}