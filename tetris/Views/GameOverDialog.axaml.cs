using Avalonia.Controls;
using Avalonia.Interactivity;

namespace tetris.Views
{
    public partial class GameOverDialog : Window
    {
        public GameOverDialog()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
