namespace FrogWinFormsApp
{
    public partial class endGameForm : Form
    {
        public endGameForm()
        {
            InitializeComponent();
            endGameLabel.Text = MainForm.Counter == 24 ? "Поздравляем! Вы справились за минимальное количество шагов!" :
                $"Продолжайте в том же духе! Вы можете сделать на {MainForm.Counter - 24} шага(ов) меньше!";
        }
    }
}
