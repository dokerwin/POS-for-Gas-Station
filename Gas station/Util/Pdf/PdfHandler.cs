using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gas_station.Util.Pdf
{
    public class PdfHandler
    {
        public void CreateInvoice(List<Product> receipt, Receipt receipt1)
        {
            var subTotal = receipt.Sum(i => i.Pro_Price);
            var invoice = new Invoice
            {
                ForegroundColor = "#0000CC",
                BackgroundColor = "#FFFFFF",
                Number = receipt1.ReceiptID.ToString(),
                Logo = new LogoImage(@"E:\Gas station\Gas station\Resources\total.png", 160, 120),
                BillFrom = new List<string> { "Eastern Berlin", "Eastern Total Gas Station", "44 Shirley Ave.", "West Berlin", "IL 60185" },
                BillTo = new List<string> { "Eastern Berlin", "Eastern Total Gas Station", "44 Shirley Ave.", "West Berlin", "IL 60185" },
                Items = receipt,
                Totals = new List<TotalRow>
                {
                    new TotalRow("Sub Total", subTotal),
                    new TotalRow("VAT @ 20%", subTotal*0.2M),
                    new TotalRow("Total", subTotal*1.2M)
                },
                Details = new List<string> {
                    "Terms & Conditions",
                    "Payment is due within 15 days",
                    string.Empty,
                    "If you have any questions concerning this invoice, contact our sales department at sales@total.com",
                    "", "Thank you for your business."
                },
                Footer = "https://www.facebook.com/AsposePDF/"
            };

            var fileStream = new FileStream("invoice.pdf", FileMode.OpenOrCreate);
            invoice.Save(fileStream);
            fileStream.Close();


        }
    }
}
