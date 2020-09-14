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
            Quiz.allDirectories = cbSubfolders.Checked;
            Quiz.gameDuration = Convert.ToInt32(cbGameDuration.Text);
            Quiz.musicDuration = Convert.ToInt32(cbMusicDuration.Text);
            Quiz.randomStart = cbRandomStart.Checked;
            Quiz.SaveSettings();
            Hide();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            LoadSettings();
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
                Quiz.lastFolder = folder_view.SelectedPath;
            }
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }
        private void LoadSettings()
        {
            cbGameDuration.Text = Quiz.gameDuration.ToString();
            cbMusicDuration.Text = Quiz.musicDuration.ToString();
            cbRandomStart.Checked = Quiz.randomStart;
            cbSubfolders.Checked = Quiz.allDirectories;
            lbSongs.Items.Clear();
            lbSongs.Items.AddRange(Quiz.list.ToArray());
        }
    }
}
