using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ember
{
    public partial class rightClick : Form
    {
        private const float _scaling = 1.2f;
        private bool isVisible;

        private FileDir fD;
        public rightClick(FileDir obj)
        {
            InitializeComponent();
            fD = obj;
            isVisible = false;
        }

        private void rightClick_Load(object sender, EventArgs e)
        {
            Width = (int)(Width * _scaling);
            
            Height = (int)(Height * _scaling);
        }

        // todo: find a way to use default apps to open files
        private void openBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        // todo: copy a file to clipboard(???)
        private void copyBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        // todo: cut a file
        private void cutBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        // todo: paste file at pointed location, if location is a file, use the parent folder
        private void pasteBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }
        
        // todo: delete the file/ folder
        private void button1_Click(object sender, EventArgs e)
        {
            FileSystemInfo info;
            if (fD.getFileDirObject() is FileInfo)
            {
                info = fD.getFileDirObject() as FileInfo;
            }
            else
            {
                info = fD.getFileDirObject() as DirectoryInfo;
            }
            
            // todo: show messageBox (for now) with information of the file/folder
        }

        private void propertiesBtn_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        public bool withinBounds(Point p)
        {
            int x = p.X, y = p.Y;
            return x >= Location.X && x <= Location.X + Size.Width && y >= Location.Y && y <= Location.Y + Size.Height;
        }

        public void CloseSelf()
        {
            Console.WriteLine("Closing the form");
            Close();
        }
    }
}
