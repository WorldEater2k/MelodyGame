using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MelodyGame
{
    public partial class FormGame : Form
    {
        Random rnd = new Random();
        int duration = Quiz.musicDuration;
        public FormGame()
        {
            InitializeComponent();
        }
        private void PlaySong()
        {
            if (Quiz.list.Count == 0)
                EndGame();
            else
            {
                duration = Quiz.musicDuration;
                int n = rnd.Next(0, Quiz.list.Count);
                MediaPlayer.URL = Quiz.list[n];
                Quiz.list.RemoveAt(n);
                lblSongsLeft.Text = Quiz.list.Count.ToString();
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
        }
        private void FormGame_Load(object sender, EventArgs e)
        {
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
            ContinueGame();
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Q)
            {
                PauseGame();
                if(MessageBox.Show("Ответ правильный?", "Игрок 1", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    lblPoints1.Text = Convert.ToString(Convert.ToInt32(lblPoints1.Text) + 1);
                ContinueGame();
            }
            else if (e.KeyData == Keys.P)
            {
                PauseGame();
                if (MessageBox.Show("Ответ правильный?", "Игрок 2", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                    lblPoints2.Text = Convert.ToString(Convert.ToInt32(lblPoints2.Text) + 1);
                ContinueGame();
            }

        }
        private void PauseGame()
        {
            timer1.Stop();
            MediaPlayer.Ctlcontrols.pause();
        }
        private void ContinueGame()
        {
            timer1.Start();
            MediaPlayer.Ctlcontrols.play();
        }
    }
}
