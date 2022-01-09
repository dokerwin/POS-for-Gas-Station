using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Gas_station.Util.MessageBox
{
    /// <summary>
    /// Interaction logic for MessageBox.xaml
    /// </summary>
    public partial class MessageBox : UserControl
    {
        
        MainWindow _mainWindow;
        public MessageBox(String message, MainWindow mainWindow)
        {
            InitializeComponent();
            _mainWindow = mainWindow;
            msg_lbl.Content = message;
            msg_lbl.HorizontalContentAlignment = HorizontalAlignment.Center;
        }

        private void close_btn_Click(object sender, RoutedEventArgs e)
        {
            UserControl parentWindow = (UserControl)this;
            parentWindow.Visibility = Visibility.Collapsed;
        }



    }
}
