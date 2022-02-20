using Gas_station.Forecourt_managment;
using Gas_station.Forecourt_managment.Controllers;
using Gas_station.Forecourt_managment.Views;
using Gas_station.MOPS;
using Gas_station.Product_mangment.Category_managment;
using Gas_station.Receipt_managment;
using Gas_station.Shift_managment;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
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
using System.Windows.Threading;

namespace Gas_station.Pos
{
    /// <summary>
    /// Interaction logic for Pos.xaml
    /// </summary>


    public partial class Pos : Page
    {

        private ForecourtHandler forecourt;
        public List<Product> products { set; get; }
        public List<Category> categories { set; get; }
        public Category category { get; set; }
        public int qt { get; set; }
        ObservableCollection<Item> receiptProducts { set; get; } = new ObservableCollection<Item>();

        private CategoryHandler categoryHandler;
        private ReceiptHanler receiptHandler;
        private MainWindow main;
        public decimal total_price { get; set; }
        public bool isTotalPressed { get; set; }

        private void LockPayBtn()
        {
            card_btn.Background = Brushes.Gray;
            cash_btn.Background = Brushes.Gray;

        }
        void initComponents()
        {
            isTotalPressed = false;
            LockPayBtn();
            cashier_lbl.Content = "Cashier ID: " + ShiftHandler.GetActualShift().ID_Cashier;
            shift_lbl.Content = "Shift ID: " + ShiftHandler.GetActualShift().ShiftID;
        }

        public Pos(MainWindow mainWindow)
        {
            category = new Category();
            categoryHandler = new CategoryHandler();
            products = new List<Product>();
            forecourt = new ForecourtHandler(this);
            receiptHandler = new ReceiptHanler();
            categories = categoryHandler.GetAllCategories();
            main = mainWindow;
            InitializeComponent();
            initComponents();
            PreparePosTime();
        }

        void PreparePosTime()
        {

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += ActualPosTime;
            timer.Start();
        }

        void ActualPosTime(object sender, EventArgs e)
        {
            time_lbl.Content = DateTime.Now.ToLongTimeString();
        }

        public void NozzleStatus(int nozzle_id, Forecourt_managment.ForecourtStatus status)
        {
            switch (nozzle_id)
            {
                case 1:
                    if (status == Forecourt_managment.ForecourtStatus.Active)
                    {
                        imgNozzle1.Source = new BitmapImage(new Uri(@"/Resources/fuel_free.png", UriKind.Relative));
                    }
                    else
                    {

                        imgNozzle1.Source = new BitmapImage(new Uri(@"/Resources/fuel_lock.png", UriKind.Relative));
                    }
                    break;

                case 2:
                    if (status == Forecourt_managment.ForecourtStatus.Active)
                    {
                        imgNozzle2.Source = new BitmapImage(new Uri(@"/Resources/fuel_free.png", UriKind.Relative));
                    }
                    else
                    {
                        imgNozzle2.Source = new BitmapImage(new Uri(@"/Resources/fuel_lock.png", UriKind.Relative));
                    }
                    break;

                case 3:
                    if (status == Forecourt_managment.ForecourtStatus.Active)
                    {
                        imgNozzle3.Source = new BitmapImage(new Uri(@"/Resources/fuel_free.png", UriKind.Relative));
                    }
                    else
                    {
                        imgNozzle3.Source = new BitmapImage(new Uri(@"/Resources/fuel_lock.png", UriKind.Relative));
                    }
                    break;
                case 4:
                    if (status == Forecourt_managment.ForecourtStatus.Active)
                    {
                        imgNozzle4.Source = new BitmapImage(new Uri(@"/Resources/fuel_free.png", UriKind.Relative));
                    }
                    else
                    {

                        imgNozzle4.Source = new BitmapImage(new Uri(@"/Resources/fuel_lock.png", UriKind.Relative));
                    }
                    break;

                default:

                    break;
            }

        }

      
        private void Scr_Keyboard_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void searcProduct_txt_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (searcProduct_txt.Text.Length == 0)
            {
                products.Clear();
                search_list.Items.Refresh();
                return;
            }
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Configuration.ProxyCreationEnabled = true;
                db.Configuration.LazyLoadingEnabled = true;
                var list = db.Products.Where(c => c.Name.StartsWith(searcProduct_txt.Text)).ToList();

                if (list.Count > 0)
                {
                    updateProductList(list);
                }
            }
        }


        public void updateProductList(List<Product> NewProducts)
        {
            products = NewProducts;
            search_list.ItemsSource = products;
            search_list.Items.Refresh();
        }


        public void updateReceiptList()
        {
            receiptProducts = receiptHandler.ProductListInReceipt();
            receipt_list.ItemsSource = receiptHandler.ProductListInReceipt();
            receipt_list.Items.Refresh();
        }



        private void receiptList_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Product;
            if (item != null && qt!=0)
            {
               
                receiptHandler.AddProduct(new Item() { product =item , quantity = qt });
                updateReceiptList();
                receipt_list.Items.Refresh();
                total_lbl.Content = receiptHandler.getSumReceipt();
            }
        }

         void total_btn_Click(object sender, RoutedEventArgs e)
        {
            if (receiptProducts.Count > 0)
            {
                isTotalPressed = true;
                card_btn.Background = Brushes.Green;
                cash_btn.Background = Brushes.Green;
            }
        }

        private void card_btn_Click(object sender, RoutedEventArgs e)
        {
            PayEnd();
        }

        private void cash_btn_Click(object sender, RoutedEventArgs e)
        {
            PayEnd();
        }

        public void PayEnd()
        {
            if (isTotalPressed)
            {
                LockPayBtn();
                isTotalPressed = false;
                receiptHandler.CloseReceipt();
                main.pageTransitionControl.ShowPage(new Util.MessageBox.MessageBox("Your payment\nwas successfull ", main));
                receiptProducts.Clear();
                receipt_list.Items.Refresh();
            }
        }


        private void Nozzle1_Click(object sender, MouseButtonEventArgs e)
        {
            main.pageTransitionControl.ShowPage(new PrepayPomp(this,1, receiptHandler));
            forecourt.SetBusyForecourt(1, true);
            NozzleStatus(1, ForecourtStatus.Busy);
        }

        private void Nozzle4_Click(object sender, MouseButtonEventArgs e)
        {
            main.pageTransitionControl.ShowPage(new PrepayPomp(this,4, receiptHandler));
            forecourt.SetBusyForecourt(4, true);
            NozzleStatus(4, ForecourtStatus.Busy);
        }

        private void Nozzle2_Click(object sender, MouseButtonEventArgs e)
        {
            main.pageTransitionControl.ShowPage(new PrepayPomp(this,2, receiptHandler));
            forecourt.SetBusyForecourt(2, true);
            NozzleStatus(2, ForecourtStatus.Busy);
        }

        private void Nozzle3_Click(object sender, MouseButtonEventArgs e)
        {
            main.pageTransitionControl.ShowPage(new PrepayPomp(this,3, receiptHandler));
            forecourt.SetBusyForecourt(3, true);
            NozzleStatus(3, ForecourtStatus.Busy);
        }

        private void Mops_Click(object sender, RoutedEventArgs e)
        {
            main.pageTransitionControl.ShowPage(new MOP_managment(this));
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = ((FrameworkElement)e.OriginalSource).DataContext as Category;

            updateProductList(categoryHandler.GetAllProductByCategory(category));
        }

        private void Button_Keyboard_Click(object sender, MouseButtonEventArgs e)
        {
            Process.Start(@"c:\Windows\Sysnative\cmd.exe", "/c osk.exe");
        }

        private void Button_Search_Click(object sender, MouseButtonEventArgs e)
        {

        }

        private void receipt_list_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
