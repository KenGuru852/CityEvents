using Avalonia.Controls;
using Avalonia.Interactivity;
using Events.ViewModels;

namespace Events.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainWindowViewModel();
        }
    }
}
