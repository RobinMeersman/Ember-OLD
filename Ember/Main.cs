using System;
using System.Drawing;
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
    }
}