using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Threading;

namespace Gas_station.Util
{
    public static class Util
    {
        public static bool IsNumeric(object Expression)
        {
            double retNum;

            bool isNum = Double.TryParse(Convert.ToString(Expression), System.Globalization.NumberStyles.Any, System.Globalization.NumberFormatInfo.InvariantInfo, out retNum);
            return isNum;
        }


        static void Time(Label label)
        {
          
            label.Content = DateTime.Now.ToLongTimeString();

        }
        private static  MainWindow mainWindow;
        public static void setMainWindow(MainWindow main)
        {
            mainWindow = main;
        }
        public static MainWindow MainPagePointer()
        {

            return mainWindow;
        }




    }





















}
