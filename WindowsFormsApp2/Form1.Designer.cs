namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.radio_Rock = new System.Windows.Forms.RadioButton();
            this.radio_Paper = new System.Windows.Forms.RadioButton();
            this.radio_Scissors = new System.Windows.Forms.RadioButton();
            this.labelComputerChoice = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // radio_Rock
            // 
            this.radio_Rock.AutoSize = true;
            this.radio_Rock.Location = new System.Drawing.Point(12, 135);
            this.radio_Rock.Name = "radio_Rock";
            this.radio_Rock.Size = new System.Drawing.Size(51, 17);
            this.radio_Rock.TabIndex = 0;
            this.radio_Rock.Text = "Rock";
            this.radio_Rock.UseVisualStyleBackColor = true;
            // 
            // radio_Paper
            // 
            this.radio_Paper.AutoSize = true;
            this.radio_Paper.Location = new System.Drawing.Point(12, 190);
            this.radio_Paper.Name = "radio_Paper";
            this.radio_Paper.Size = new System.Drawing.Size(53, 17);
            this.radio_Paper.TabIndex = 1;
            this.radio_Paper.Text = "Paper";
            this.radio_Paper.UseVisualStyleBackColor = true;
            // 
            // radio_Scissors
            // 
            this.radio_Scissors.AutoSize = true;
            this.radio_Scissors.Location = new System.Drawing.Point(12, 249);
            this.radio_Scissors.Name = "radio_Scissors";
            this.radio_Scissors.Size = new System.Drawing.Size(64, 17);
            this.radio_Scissors.TabIndex = 2;
            this.radio_Scissors.Text = "Scissors";
            this.radio_Scissors.UseVisualStyleBackColor = true;
            // 
            // labelComputerChoice
            // 
            this.labelComputerChoice.AutoSize = true;
            this.labelComputerChoice.Location = new System.Drawing.Point(228, 135);
            this.labelComputerChoice.Name = "labelComputerChoice";
            this.labelComputerChoice.Size = new System.Drawing.Size(0, 13);
            this.labelComputerChoice.TabIndex = 3;
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Location = new System.Drawing.Point(228, 207);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(0, 13);
            this.labelScore.TabIndex = 4;
            // 
            // buttonPlay
            // 
            this.buttonPlay.Location = new System.Drawing.Point(330, 322);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(75, 23);
            this.buttonPlay.TabIndex = 5;
            this.buttonPlay.Text = "Play!";
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonPlay);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labelComputerChoice);
            this.Controls.Add(this.radio_Scissors);
            this.Controls.Add(this.radio_Paper);
            this.Controls.Add(this.radio_Rock);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_Rock;
        private System.Windows.Forms.RadioButton radio_Paper;
        private System.Windows.Forms.RadioButton radio_Scissors;
        private System.Windows.Forms.Label labelComputerChoice;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.Button buttonPlay;
    }
}

