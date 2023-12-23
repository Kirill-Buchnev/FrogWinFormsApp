namespace FrogWinFormsApp
{
    partial class endGameForm
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
            endGamePictureBox = new PictureBox();
            endGameLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)endGamePictureBox).BeginInit();
            SuspendLayout();
            // 
            // endGamePictureBox
            // 
            endGamePictureBox.Image = Properties.Resources.winnerFrog;
            endGamePictureBox.InitialImage = Properties.Resources.winnerFrog;
            endGamePictureBox.Location = new Point(12, 12);
            endGamePictureBox.Name = "endGamePictureBox";
            endGamePictureBox.Size = new Size(413, 303);
            endGamePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            endGamePictureBox.TabIndex = 0;
            endGamePictureBox.TabStop = false;
            // 
            // endGameLabel
            // 
            endGameLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            endGameLabel.Location = new Point(12, 331);
            endGameLabel.Name = "endGameLabel";
            endGameLabel.Size = new Size(413, 82);
            endGameLabel.TabIndex = 1;
            endGameLabel.Text = "Поздравляем! Вы справились за минимальное количество шагов!";
            endGameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // endGameForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(437, 432);
            Controls.Add(endGameLabel);
            Controls.Add(endGamePictureBox);
            Name = "endGameForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Попрыгушки";
            ((System.ComponentModel.ISupportInitialize)endGamePictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox endGamePictureBox;
        private Label endGameLabel;
    }
}