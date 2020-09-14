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
    public partial class formMain : Form
    {
        FormSettings fs = new FormSettings();
        FormGame fg = new FormGame();
        public formMain()
        {
            InitializeComponent();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            fs.ShowDialog();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (Quiz.lastFolder == "")
                MessageBox.Show("Перед началом игры зайдите в настройки и выберите папку с музыкой!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                Hide();
                fg.ShowDialog();
            }
        }

        private void formMain_Load(object sender, EventArgs e)
        {
            Quiz.ReadSettings();
            Quiz.ReadMusic();
        }
    }
}
