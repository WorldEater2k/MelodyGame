namespace MelodyGame
{
    partial class FormGuessing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuessing));
            this.lblMessage = new System.Windows.Forms.Label();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnWrong = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lblTimer = new System.Windows.Forms.Label();
            this.lblShowAnswer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.BackColor = System.Drawing.Color.SteelBlue;
            this.lblMessage.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMessage.ForeColor = System.Drawing.Color.White;
            this.lblMessage.Location = new System.Drawing.Point(94, 30);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(76, 28);
            this.lblMessage.TabIndex = 0;
            this.lblMessage.Text = "Игрок";
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.Color.LightBlue;
            this.btnRight.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnRight.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRight.FlatAppearance.BorderSize = 3;
            this.btnRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRight.Location = new System.Drawing.Point(34, 198);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(94, 37);
            this.btnRight.TabIndex = 1;
            this.btnRight.Text = "Да";
            this.btnRight.UseVisualStyleBackColor = false;
            // 
            // btnWrong
            // 
            this.btnWrong.BackColor = System.Drawing.Color.LightBlue;
            this.btnWrong.DialogResult = System.Windows.Forms.DialogResult.No;
            this.btnWrong.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnWrong.FlatAppearance.BorderSize = 3;
            this.btnWrong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnWrong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Azure;
            this.btnWrong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWrong.Font = new System.Drawing.Font("Sitka Small", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWrong.Location = new System.Drawing.Point(139, 198);
            this.btnWrong.Name = "btnWrong";
            this.btnWrong.Size = new System.Drawing.Size(94, 37);
            this.btnWrong.TabIndex = 2;
            this.btnWrong.Text = "Нет";
            this.btnWrong.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "дал верный ответ?";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.BackColor = System.Drawing.Color.White;
            this.lblTimer.Font = new System.Drawing.Font("Sitka Small", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTimer.ForeColor = System.Drawing.Color.Black;
            this.lblTimer.Location = new System.Drawing.Point(114, 115);
            this.lblTimer.MinimumSize = new System.Drawing.Size(40, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(40, 28);
            this.lblTimer.TabIndex = 4;
            this.lblTimer.Text = "0";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblShowAnswer
            // 
            this.lblShowAnswer.AutoSize = true;
            this.lblShowAnswer.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblShowAnswer.Location = new System.Drawing.Point(72, 162);
            this.lblShowAnswer.Name = "lblShowAnswer";
            this.lblShowAnswer.Size = new System.Drawing.Size(114, 19);
            this.lblShowAnswer.TabIndex = 5;
            this.lblShowAnswer.Text = "Показать ответ";
            this.lblShowAnswer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblShowAnswer.Click += new System.EventHandler(this.lblShowAnswer_Click);
            // 
            // FormGuessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::MelodyGame.Properties.Resources.back;
            this.ClientSize = new System.Drawing.Size(265, 251);
            this.Controls.Add(this.lblShowAnswer);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWrong);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.lblMessage);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormGuessing";
            this.Text = "Guessing";
            this.Load += new System.EventHandler(this.FormGuessing_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnWrong;
        public System.Windows.Forms.Label lblMessage;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer2;
        public System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Label lblShowAnswer;
    }
}