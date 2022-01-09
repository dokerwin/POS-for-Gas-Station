using Gas_station.Shift_managment;
using Gas_station.Util.Pdf;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Receipt_managment
{
    public class ReceiptHanler
    {
        private List<Product> products { get; set; }
        private ObservableCollection<Item> receipt_basket {get;set;} = new ObservableCollection<Item>();

        public ReceiptHanler()
        {
            products = new List<Product>();
        }

        public ObservableCollection<Item> ProductListInReceipt () 
        {
            return receipt_basket;
        }
        public void OpenReceipt()
        {
            if (receipt_basket != null)
            {
                receipt_basket.Clear();
            }
            else
            {
                receipt_basket = new ObservableCollection<Item>();
            }
        }

        public void AddProduct(Item myItem)
        {
            receipt_basket.Add(myItem);
        }

        public void RemoveProduct(Item myItem)
        {
           receipt_basket.Remove(myItem);
        }
        public void CloseReceipt()
        {
            Receipt receipt = new Receipt();
            receipt.DealTime = DateTime.Now;
            receipt.Shift = ShiftHandler.GetActualShift();
            receipt.Receipt_Price = getSumReceipt();
            receipt.Number_Product = receipt_basket.Count;

            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Receipts.Add(receipt);
                db.SaveChanges();
                foreach (var prod in receipt_basket)
                {
                    db.ProductReceipts.Add(new ProductReceipt
                    {
                        ID_Product = prod.product.ProductID,
                        ID_Receipt = receipt.ReceiptID
                    });
                }
                db.SaveChanges();
                PdfHandler pdfHandler = new PdfHandler();
               // pdfHandler.CreateInvoice(receipt_basket.Keys, receipt);
            }
            products.Clear();
        }
        public void AbortReceipt()
        {
            receipt_basket.Clear();
        }

        public decimal getSumReceipt()
        {
            return receipt_basket.Sum(item => item.product.Pro_Price * item.quantity);
        }


        public Receipt findReceipt(int idReceipt)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                return db.Receipts.FirstOrDefault(m => m.ReceiptID == idReceipt);
            }
        }


        static public List<Product> ProductInReceipt(int idReceipt)
        {
            List<Product> a = new List<Product>();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                var ass  = (from product in db.Products
                                    join productReceipt in db.ProductReceipts
                                on   product.ProductID equals productReceipt.ID_Product
                    where productReceipt.ID_Receipt == idReceipt
                            select new { Product = product }).ToList();
                foreach(var s in ass)
                {
                    if(s.Product.Category!=null)
                    a.Add(s.Product);
                }
            }
            return a;
        }



    }
}
