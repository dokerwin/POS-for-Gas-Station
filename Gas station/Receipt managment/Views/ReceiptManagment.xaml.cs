using Gas_station.Util.Pdf;
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

namespace Gas_station.Receipt_managment.Views
{
    /// <summary>
    /// Interaction logic for ReceiptManagment.xaml
    /// </summary>
    public partial class ReceiptManagment : Page
    {
        ReceiptHanler receiptHanler;
        public List<Receipt> _receipts { get; set; }

        MainWindow mainWindow;
        public int _receiptId { get; set; }
        public ReceiptManagment(MainWindow mainWindow)
        {
            this.mainWindow = mainWindow;
            receiptHanler = new ReceiptHanler();
            _receipts = new List<Receipt>();
            InitializeComponent();
        }

        private void topOrders_Click(object sender, RoutedEventArgs e)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var list = db.Receipts.Take(100).ToList();

                if (list.Count > 0)
                {
                    updateReceiptList(list);
                }
            }
        }


        private void updateReceiptList(List<Receipt> receipts)
        {
            _receipts = receipts;
            receiptListView.ItemsSource = _receipts;
            receiptListView.Items.Refresh();
        }

        private void Id_receipt_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
           
            if (Id_receipt_txt.Text.Length == 0)
            {
                _receipts.Clear();
                receiptListView.Items.Refresh();
                return;
            }
            _receiptId = int.Parse(Id_receipt_txt.Text.ToString());
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var list = db.Receipts.Where(c => c.ReceiptID == _receiptId).ToList();
             
                if (list.Count > 0)
                {
                    updateReceiptList(list);
                }
            }
        }

        private void receiptList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Receipt;
            if (item != null)
            {
                using (Gas_stationDb db = new Gas_stationDb())
                {
                    Receipt receipt = db.Receipts.First(a => a.ReceiptID == item.ReceiptID);
                    var ass = ReceiptHanler.ProductInReceipt(receipt.ReceiptID);
                    if (ass != null)
                    {
                        mainWindow.pageTransitionControl.ShowPage(new ReceiptDetails());
                        PdfHandler pdfHandler = new PdfHandler();
                        pdfHandler.CreateInvoice(ass, receipt);
                    }
                }
            }
        }

        private void receiptListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
