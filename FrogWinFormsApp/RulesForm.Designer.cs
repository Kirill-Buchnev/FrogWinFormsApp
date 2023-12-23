namespace FrogWinFormsApp
{
    partial class rulesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(rulesForm));
            headingRulesLebel = new Label();
            textRulesLabel = new Label();
            okButton = new Button();
            SuspendLayout();
            // 
            // headingRulesLebel
            // 
            headingRulesLebel.AutoSize = true;
            headingRulesLebel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            headingRulesLebel.Location = new Point(270, 36);
            headingRulesLebel.Name = "headingRulesLebel";
            headingRulesLebel.Size = new Size(190, 32);
            headingRulesLebel.TabIndex = 0;
            headingRulesLebel.Text = "Правила игры:";
            // 
            // textRulesLabel
            // 
            textRulesLabel.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            textRulesLabel.Location = new Point(53, 117);
            textRulesLabel.Name = "textRulesLabel";
            textRulesLabel.Size = new Size(721, 157);
            textRulesLabel.TabIndex = 1;
            textRulesLabel.Text = resources.GetString("textRulesLabel.Text");
            // 
            // okButton
            // 
            okButton.Location = new Point(304, 291);
            okButton.Name = "okButton";
            okButton.Size = new Size(137, 59);
            okButton.TabIndex = 2;
            okButton.Text = "OK";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // rulesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 384);
            Controls.Add(okButton);
            Controls.Add(textRulesLabel);
            Controls.Add(headingRulesLebel);
            Name = "rulesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Попрыгушки";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label headingRulesLebel;
        private Label textRulesLabel;
        private Button okButton;
    }
}