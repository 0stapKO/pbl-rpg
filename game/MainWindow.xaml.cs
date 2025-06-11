using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Engine.View_models;

namespace game
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private GameSession gameSession;
        public MainWindow()
        {
            InitializeComponent();
            gameSession = new GameSession();

            DataContext = gameSession;
        }

        private void OnClickMoveUp(object sender, RoutedEventArgs e)
        {
            gameSession.MoveUp();
        }
        private void OnClickMoveDown(object sender, RoutedEventArgs e)
        {
            gameSession.MoveDown();
        }
        private void OnClickMoveLeft(object sender, RoutedEventArgs e)
        {
            gameSession.MoveLeft();
        }
        private void OnClickMoveRight(object sender, RoutedEventArgs e)
        {
            gameSession.MoveRight();
        }
    }
}