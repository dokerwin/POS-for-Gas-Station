using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MWS.Helper_Classes
{
    // Declare a delegate type for an event.
    public  delegate void MyEventHandler(object sender, MyEventArgs e);

    // Derive a class from EventArgs.
    public  class MyEventArgs : EventArgs
    {
        public int EventNum;
    }

    // Declare a class that contains an event.
    public sealed class MyEvent
    {
        static int count = 0;

        public event MyEventHandler SomeEvent;

        private MyEvent() { }

        private static MyEvent _instance;

        public static MyEvent GetInstance()
        {
            if (_instance == null)
            {
                _instance = new MyEvent();
            }
            return _instance;
        }

        // This raises SomeEvent.
        public void OnUpdateCustomerListEvent()
        {
            MyEventArgs arg = new MyEventArgs();

            if (SomeEvent != null)
            {
                arg.EventNum = count++;
                SomeEvent(this, arg);
            }
        }
    }
}
