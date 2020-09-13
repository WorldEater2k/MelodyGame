using System;
using System.Windows.Forms;
using System.IO;

namespace MelodyGame
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Quiz.SaveSettings();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder_view = new FolderBrowserDialog();
            if (folder_view.ShowDialog() == DialogResult.OK)
            {
                string[] music_list = Directory.GetFiles(folder_view.SelectedPath, "*.mp3", cbSubfolders.Checked?
                                                         SearchOption.AllDirectories : SearchOption.TopDirectoryOnly);
                lbSongs.Items.Clear();
                lbSongs.Items.AddRange(music_list);
                Quiz.list.Clear();
                Quiz.list.AddRange(music_list);
            }
            else
            {

            }
        }
    }
}
