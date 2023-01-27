using System;
using System.Windows.Forms;

namespace Ember
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Properties.Settings.Default.images = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Properties.Settings.Default.documents = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            Properties.Settings.Default.music = Environment.GetFolderPath(Environment.SpecialFolder.MyMusic);
            Properties.Settings.Default.videos = Environment.GetFolderPath(Environment.SpecialFolder.MyVideos);
            Properties.Settings.Default.desktop = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
            Application.Run(new Main());
        }
    }
}