namespace FrogWinFormsApp
{
    public partial class MainForm : Form
    {
        public static int Counter = 0;
        private List<PictureBox> pictureBoxes = new List<PictureBox>();
        public MainForm()
        {
            InitializeComponent();
            foreach (var ctrl in this.Controls)
            {
                var pic = ctrl as PictureBox;
                if (pic != null) pictureBoxes.Add(pic);
            }
            scoreLabel.Text = $"Количество прыжков: {Counter}";
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            Swap(sender as PictureBox);
            if (CheckPictureBoxesLocation()) OpenEndGameForm();
        }

        private bool CheckPictureBoxesLocation()
        {
            return pictureBoxes.Where(pic => pic.Name.StartsWith("left")).All(pic => pic.Location.X > emptyPictureBox.Location.X)
                && pictureBoxes.Where(pic => pic.Name.StartsWith("right")).All(pic => pic.Location.X < emptyPictureBox.Location.X);
        }

        private void OpenEndGameForm()
        {
            this.Hide();
            var endGameForm = new endGameForm();
            endGameForm.ShowDialog();
            this.Close();
        }

        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if (distance > 2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else
            {
                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                Counter++;
                scoreLabel.Text = $"Количество прыжков: {Counter}";
            }
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void rulesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            new rulesForm().ShowDialog();
            this.Show();
        }
    }
}