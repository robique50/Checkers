using System.Windows;

using MAP_Tema2_Checkers.Utils;

namespace MAP_Tema2_Checkers.Views
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewNavigator.MainWindow = this;
            ViewNavigator.ChangeToGamePage();
        }
    }
}
