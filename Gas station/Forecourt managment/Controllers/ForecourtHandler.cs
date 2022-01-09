using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Threading;

namespace Gas_station.Forecourt_managment.Controllers
{
    public class ForecourtHandler
    {
        List<DispatcherTimer> timers = new List<DispatcherTimer>();


        private Pos.Pos mainPos;
        private static List<FuelDelivery> _fuelDelivery;
        private static List<Cistern> _cistern;
        public ForecourtHandler(Pos.Pos mainWindow)
        {
            mainPos = mainWindow;
            _fuelDelivery = new List<FuelDelivery>();
            _cistern = new List<Cistern>();
            initTimer();
            initCistern();
            initFuelDelivery();
        }

        private Dictionary<int, bool> forecourts { get; set; } = new Dictionary<int, bool>()
          { { 1, false },
            { 2, false },
            { 3, false },
            { 4, false } };

        public void SetBusyForecourt(int IdNozzle, bool status)
        {
            forecourts[IdNozzle] = status;
            timers[IdNozzle].Start();
        }

        public bool IsBusyForecourt(int IdNozzle)
        {
            return forecourts[IdNozzle];
        }

        public void TimerStop(int id)
        {
            timers[id].Stop();
        }
        public void TimerStart(int id)
        {
            timers[id].Start();
        }
        private void initTimer()
        {
            for (int i = 0; i < 5; i++)
            {
                DispatcherTimer timer = new DispatcherTimer();
                timer.Tag = i.ToString();
                timer.Interval = TimeSpan.FromSeconds(30); //number of your choice
                timers.Add(timer);
                timer.Tick += TimerTick;
            }
        }
        private void TimerTick(object sender, EventArgs e)
        {
            var senderex = ((DispatcherTimer)sender).Tag.ToString();
            int a = System.Convert.ToInt32(senderex);
            mainPos.NozzleStatus(a, ForecourtStatus.Active);
            timers[a].Stop();
        }

    


        private void initCistern()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                foreach (var cis in db.Cisterns.ToList()) {
                    if (cis.Product != null)
                    {
                        _cistern.Add(cis);
                    }
                }
            }
        }
        private void  initFuelDelivery()
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
                _fuelDelivery = db.FuelDeliveries.ToList();

            }


        }
        public static List<Cistern> CisternList()
        {
            return _cistern;
        }
        public static List<FuelDelivery> FuelDeliveryList()
        {
            return _fuelDelivery;
        }

        public static List<Product> FuelList()
        {
            List<Product> fuelList = new List<Product>();
            using (Gas_stationDb db = new Gas_stationDb())
            {
                db.Configuration.ProxyCreationEnabled = true;
                db.Configuration.LazyLoadingEnabled = true;
                foreach (var list1 in db.Products.Where(r => r.Category.Cat_Name == "Fuel").ToList())
                {
                    if (list1.Category != null || list1.Promotion != null)
                    {
                        fuelList.Add(list1);
                    }
                }
            }
            return fuelList;
        }

        public static bool Prepay(int forecourt, decimal amount, Product product)
        {
            using (Gas_stationDb db = new Gas_stationDb())
            {
               // return db.Products.Where(r => r.Category.Cat_Name == "Fuel").ToList();
            }

            return true;
        }
    }
}
