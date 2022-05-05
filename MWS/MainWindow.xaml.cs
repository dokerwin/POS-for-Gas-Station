
using System.Windows;

namespace MWS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ApplicationViewModel context = new ApplicationViewModel();
            this.DataContext = context;
        }

    }
}
