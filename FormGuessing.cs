using System;
using System.Windows.Forms;
using System.Drawing;

namespace MelodyGame
{
    public partial class FormGuessing : Form
    {
        int answerTime = 10;
        public FormGuessing()
        {
            InitializeComponent();
        }
        private void FormGuessing_Load(object sender, EventArgs e)
        {
            answerTime = 10;
            lblTimer.Text = answerTime.ToString();
            timer2.Start();

        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            answerTime--;
            lblTimer.Text = answerTime.ToString();
            if (answerTime == 0)
            {
                timer2.Stop();
                DialogResult = DialogResult.No;
            }
        }
        private void lblShowAnswer_Click(object sender, EventArgs e)
        {
            lblShowAnswer.Text = Quiz.currentSong;
            lblShowAnswer.Location = new Point ((Width-lblShowAnswer.Width)/2, 162);
        }
    }
}
