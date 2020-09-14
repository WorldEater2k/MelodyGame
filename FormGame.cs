using System;
using System.Windows.Forms;
using System.Media;

namespace MelodyGame
{
    public partial class FormGame : Form
    {
        Random rnd = new Random();
        int duration;
        bool[] players = new bool[2];
        public FormGame()
        {
            InitializeComponent();
        }
        private void PlaySong()
        {
            if (Quiz.list.Count == 0)
                Close();
            else
            {
                duration = Quiz.musicDuration;
                lblSecondsLeft.Text = duration.ToString();
                int n = rnd.Next(0, Quiz.list.Count);
                MediaPlayer.URL = Quiz.list[n];
                Quiz.currentSong = System.IO.Path.GetFileNameWithoutExtension(Quiz.list[n]);
                Quiz.list.RemoveAt(n);
                lblSongsLeft.Text = Quiz.list.Count.ToString();
                players[0] = false;
                players[1] = false;
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Start();
            PlaySong();
        }
        private void FormGame_FormClosed(object sender, FormClosedEventArgs e)
        {
            EndGame();
        }

        private void EndGame()
        {
            MediaPlayer.Ctlcontrols.stop();
            timer1.Stop();
            if (Convert.ToInt32(lblPoints1.Text) > Convert.ToInt32(lblPoints2.Text))
                MessageBox.Show("Победил Игрок 1!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else if (Convert.ToInt32(lblPoints1.Text) < Convert.ToInt32(lblPoints2.Text))
                MessageBox.Show("Победил Игрок 2!", "Поздравляем", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
                MessageBox.Show("У вас ничья.", "Конец игры", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            duration = Quiz.musicDuration;
            lblSongsLeft.Text = Quiz.list.Count.ToString();
            progressBar1.Value = 0;
            progressBar1.Maximum = Quiz.gameDuration;
            lblSecondsLeft.Text = duration.ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value++;
            duration--;
            lblSecondsLeft.Text = duration.ToString();
            if (progressBar1.Value == progressBar1.Maximum)
            {
                EndGame();
                return;
            }
            if (duration == 0)
                PlaySong();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseGame();
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            timer1.Start();
            MediaPlayer.Ctlcontrols.play();
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (!timer1.Enabled)
                return;
            if (players[0] == false && e.KeyData == Keys.Q)
            {
                PauseGame();
                FormGuessing fg = new FormGuessing();
                fg.lblMessage.Text = "Игрок 1";
                SoundPlayer sp = new SoundPlayer(Properties.Resources.player1);
                sp.PlaySync();
                players[0] = true;
                if (fg.ShowDialog() == DialogResult.Yes)
                {
                    lblPoints1.Text = Convert.ToString(Convert.ToInt32(lblPoints1.Text) + 1);
                    SoundPlayer sp2 = new SoundPlayer(Properties.Resources.right_answer);
                    sp2.PlaySync();
                    players[1] = true;
                }
                else
                {
                    SoundPlayer sp2 = new SoundPlayer(Properties.Resources.fail_sound);
                    sp2.PlaySync();
                }
            }
            else if (players[1] == false && e.KeyData == Keys.P)
            {
                PauseGame();
                FormGuessing fg = new FormGuessing();
                fg.lblMessage.Text = "Игрок 2";
                SoundPlayer sp = new SoundPlayer(Properties.Resources.player2);
                sp.PlaySync();
                players[1] = true;
                if (fg.ShowDialog() == DialogResult.Yes)
                {
                    lblPoints2.Text = Convert.ToString(Convert.ToInt32(lblPoints2.Text) + 1);
                    SoundPlayer sp2 = new SoundPlayer(Properties.Resources.right_answer);
                    sp2.PlaySync();
                    players[0] = true;
                }
                else
                {
                    SoundPlayer sp2 = new SoundPlayer(Properties.Resources.fail_sound);
                    sp2.PlaySync();
                }
            }

        }
        private void PauseGame()
        {
            timer1.Stop();
            MediaPlayer.Ctlcontrols.pause();
        }
        private void MediaPlayer_OpenStateChange(object sender, AxWMPLib._WMPOCXEvents_OpenStateChangeEvent e)
        {
            if (Quiz.randomStart == true && MediaPlayer.openState == WMPLib.WMPOpenState.wmposMediaOpen)
                MediaPlayer.Ctlcontrols.currentPosition = rnd.Next(0, (int)MediaPlayer.currentMedia.duration - Quiz.musicDuration);
        }

        private void btnMinus1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPoints1.Text) > 0)
                lblPoints1.Text = Convert.ToString(Convert.ToInt32(lblPoints1.Text) - 1);
        }

        private void btnPlus1_Click(object sender, EventArgs e)
        {
            lblPoints1.Text = Convert.ToString(Convert.ToInt32(lblPoints1.Text) + 1);
        }

        private void btnMinus2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(lblPoints2.Text) > 0)
                lblPoints2.Text = Convert.ToString(Convert.ToInt32(lblPoints2.Text) - 1);
        }

        private void btnPlus2_Click(object sender, EventArgs e)
        {
            lblPoints2.Text = Convert.ToString(Convert.ToInt32(lblPoints2.Text) + 1);
        }
    }
}
