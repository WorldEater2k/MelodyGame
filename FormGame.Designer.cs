namespace MelodyGame
{
    partial class FormGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.MediaPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnNext = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPoints1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPoints2 = new System.Windows.Forms.Label();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnContinue = new System.Windows.Forms.Button();
            this.lblSongsLeft = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblSecondsLeft = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnMinus1 = new System.Windows.Forms.Button();
            this.btnPlus1 = new System.Windows.Forms.Button();
            this.btnMinus2 = new System.Windows.Forms.Button();
            this.btnPlus2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // MediaPlayer
            // 
            this.MediaPlayer.Enabled = true;
            this.MediaPlayer.Location = new System.Drawing.Point(2, 329);
            this.MediaPlayer.Name = "MediaPlayer";
            this.MediaPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("MediaPlayer.OcxState")));
            this.MediaPlayer.Size = new System.Drawing.Size(92, 46);
            this.MediaPlayer.TabIndex = 0;
            this.MediaPlayer.Visible = false;
            this.MediaPlayer.OpenStateChange += new AxWMPLib._WMPOCXEvents_OpenStateChangeEventHandler(this.MediaPlayer_OpenStateChange);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Orchid;
            this.btnNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNext.FlatAppearance.BorderSize = 2;
            this.btnNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkMagenta;
            this.btnNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnNext.Location = new System.Drawing.Point(168, 210);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(280, 43);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "Следующая";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DarkOrchid;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(41, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "Игрок 1";
            // 
            // lblPoints1
            // 
            this.lblPoints1.AutoSize = true;
            this.lblPoints1.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblPoints1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoints1.ForeColor = System.Drawing.Color.White;
            this.lblPoints1.Location = new System.Drawing.Point(76, 70);
            this.lblPoints1.Name = "lblPoints1";
            this.lblPoints1.Size = new System.Drawing.Size(25, 28);
            this.lblPoints1.TabIndex = 3;
            this.lblPoints1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.DarkOrchid;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(463, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 28);
            this.label3.TabIndex = 4;
            this.label3.Text = "Игрок 2";
            // 
            // lblPoints2
            // 
            this.lblPoints2.AutoSize = true;
            this.lblPoints2.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblPoints2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPoints2.ForeColor = System.Drawing.Color.White;
            this.lblPoints2.Location = new System.Drawing.Point(501, 70);
            this.lblPoints2.Name = "lblPoints2";
            this.lblPoints2.Size = new System.Drawing.Size(25, 28);
            this.lblPoints2.TabIndex = 5;
            this.lblPoints2.Text = "0";
            // 
            // btnPause
            // 
            this.btnPause.BackColor = System.Drawing.Color.Thistle;
            this.btnPause.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnPause.FlatAppearance.BorderSize = 2;
            this.btnPause.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.btnPause.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPause.Location = new System.Drawing.Point(168, 257);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(138, 37);
            this.btnPause.TabIndex = 6;
            this.btnPause.Text = "Пауза";
            this.btnPause.UseVisualStyleBackColor = false;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.BackColor = System.Drawing.Color.Thistle;
            this.btnContinue.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnContinue.FlatAppearance.BorderSize = 2;
            this.btnContinue.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Plum;
            this.btnContinue.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnContinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContinue.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnContinue.Location = new System.Drawing.Point(310, 257);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(138, 37);
            this.btnContinue.TabIndex = 7;
            this.btnContinue.Text = "Продолжить";
            this.btnContinue.UseVisualStyleBackColor = false;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // lblSongsLeft
            // 
            this.lblSongsLeft.AutoSize = true;
            this.lblSongsLeft.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblSongsLeft.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSongsLeft.ForeColor = System.Drawing.Color.White;
            this.lblSongsLeft.Location = new System.Drawing.Point(283, 70);
            this.lblSongsLeft.MinimumSize = new System.Drawing.Size(40, 0);
            this.lblSongsLeft.Name = "lblSongsLeft";
            this.lblSongsLeft.Size = new System.Drawing.Size(40, 28);
            this.lblSongsLeft.TabIndex = 8;
            this.lblSongsLeft.Text = "0";
            this.lblSongsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DarkOrchid;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(208, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 28);
            this.label2.TabIndex = 9;
            this.label2.Text = "Осталось песен:";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.DarkMagenta;
            this.progressBar1.Location = new System.Drawing.Point(46, 300);
            this.progressBar1.Maximum = 0;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(511, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblSecondsLeft
            // 
            this.lblSecondsLeft.AutoSize = true;
            this.lblSecondsLeft.BackColor = System.Drawing.Color.White;
            this.lblSecondsLeft.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblSecondsLeft.Location = new System.Drawing.Point(283, 140);
            this.lblSecondsLeft.MinimumSize = new System.Drawing.Size(40, 0);
            this.lblSecondsLeft.Name = "lblSecondsLeft";
            this.lblSecondsLeft.Size = new System.Drawing.Size(40, 28);
            this.lblSecondsLeft.TabIndex = 11;
            this.lblSecondsLeft.Text = "0";
            this.lblSecondsLeft.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DarkOrchid;
            this.label4.Location = new System.Drawing.Point(37, 13);
            this.label4.MinimumSize = new System.Drawing.Size(100, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 100);
            this.label4.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.DarkOrchid;
            this.label5.Location = new System.Drawing.Point(460, 13);
            this.label5.MinimumSize = new System.Drawing.Size(100, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 100);
            this.label5.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DarkOrchid;
            this.label6.Location = new System.Drawing.Point(199, 13);
            this.label6.MinimumSize = new System.Drawing.Size(200, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 100);
            this.label6.TabIndex = 14;
            // 
            // btnMinus1
            // 
            this.btnMinus1.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinus1.FlatAppearance.BorderSize = 0;
            this.btnMinus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus1.Location = new System.Drawing.Point(44, 70);
            this.btnMinus1.Name = "btnMinus1";
            this.btnMinus1.Size = new System.Drawing.Size(26, 27);
            this.btnMinus1.TabIndex = 17;
            this.btnMinus1.Text = "–";
            this.btnMinus1.UseVisualStyleBackColor = false;
            this.btnMinus1.Click += new System.EventHandler(this.btnMinus1_Click);
            // 
            // btnPlus1
            // 
            this.btnPlus1.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnPlus1.FlatAppearance.BorderSize = 0;
            this.btnPlus1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus1.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus1.Location = new System.Drawing.Point(107, 70);
            this.btnPlus1.Name = "btnPlus1";
            this.btnPlus1.Size = new System.Drawing.Size(26, 27);
            this.btnPlus1.TabIndex = 18;
            this.btnPlus1.Text = "+";
            this.btnPlus1.UseVisualStyleBackColor = false;
            this.btnPlus1.Click += new System.EventHandler(this.btnPlus1_Click);
            // 
            // btnMinus2
            // 
            this.btnMinus2.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnMinus2.FlatAppearance.BorderSize = 0;
            this.btnMinus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinus2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMinus2.Location = new System.Drawing.Point(469, 70);
            this.btnMinus2.Name = "btnMinus2";
            this.btnMinus2.Size = new System.Drawing.Size(26, 27);
            this.btnMinus2.TabIndex = 19;
            this.btnMinus2.Text = "–";
            this.btnMinus2.UseVisualStyleBackColor = false;
            this.btnMinus2.Click += new System.EventHandler(this.btnMinus2_Click);
            // 
            // btnPlus2
            // 
            this.btnPlus2.BackColor = System.Drawing.Color.DarkOrchid;
            this.btnPlus2.FlatAppearance.BorderSize = 0;
            this.btnPlus2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlus2.Font = new System.Drawing.Font("Sitka Small", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnPlus2.Location = new System.Drawing.Point(531, 70);
            this.btnPlus2.Name = "btnPlus2";
            this.btnPlus2.Size = new System.Drawing.Size(26, 27);
            this.btnPlus2.TabIndex = 20;
            this.btnPlus2.Text = "+";
            this.btnPlus2.UseVisualStyleBackColor = false;
            this.btnPlus2.Click += new System.EventHandler(this.btnPlus2_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MelodyGame.Properties.Resources.back2;
            this.ClientSize = new System.Drawing.Size(600, 380);
            this.Controls.Add(this.btnPlus2);
            this.Controls.Add(this.btnMinus2);
            this.Controls.Add(this.btnPlus1);
            this.Controls.Add(this.btnMinus1);
            this.Controls.Add(this.lblSecondsLeft);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblSongsLeft);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblPoints2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblPoints1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.MediaPlayer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormGame";
            this.Text = "Игра";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormGame_FormClosed);
            this.Load += new System.EventHandler(this.FormGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MediaPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer MediaPlayer;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblPoints1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblPoints2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Label lblSongsLeft;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblSecondsLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnMinus1;
        private System.Windows.Forms.Button btnPlus1;
        private System.Windows.Forms.Button btnMinus2;
        private System.Windows.Forms.Button btnPlus2;
    }
}