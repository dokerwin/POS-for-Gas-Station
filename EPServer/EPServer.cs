using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace EPServer
{
    public class CEPServer
    {
       private IPHostEntry host;
       private IPAddress ipAddress;
       private IPEndPoint localEndPoint;
       private Socket listener;
       private Socket handler;


        private void InitServer()
        {
            try
            {
                // If a host has multiple addresses, you will get a list of addresses
                host = Dns.GetHostEntry("localhost");
                ipAddress = host.AddressList[0];
                localEndPoint = new IPEndPoint(ipAddress, 11000);
                // Create a Socket that will use Tcp protocol
                listener = new Socket(ipAddress.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                // Get Host IP Address that is used to establish a connection
                // In this case, we get one IP address of localhost that is IP : 127.0.0.1

                // A Socket must be associated with an endpoint using the Bind method
                listener.Bind(localEndPoint);
                // Specify how many requests a Socket can listen before it gives Server busy response.
                // We will listen 10 requests at a time
                listener.Listen(10);
                handler = listener.Accept();
            }
            catch (Exception e)
            {
                return;
            }
        }

        public CEPServer()
        {
            InitServer();
            Thread workerThread = new Thread(new ThreadStart(HandleMessages));
            workerThread.Start();
        }

        public void HandleEFTResponse(string response)
        {
            //
            int a = 10;

        }

        public void HandleMessages()
        {
            while (true)
            {
                try
                {
                    // Incoming data from the client.
                    string data = null;
                    byte[] bytes = null;

                    while (true)
                    {
                        bytes = new byte[1024];
                        int bytesRec = handler.Receive(bytes);
                        data += Encoding.ASCII.GetString(bytes, 0, bytesRec);
                        if (data.IndexOf("<EOF>") > -1)
                        {
                            break;
                        }
                    }
                    if (data != null)
                    {
                        HandleEFTResponse(data);
                    }
                }
                catch (Exception e)
                {
                    break;
                }
            }
        }
        private void SendRequest(string request)
        {
            try
            {

                byte[] msg = Encoding.ASCII.GetBytes(request);
                handler.Send(msg);
            }
            catch (Exception e)
            {
               //handle error
            }
        }
        public void SendRequestToEFT(string request)
        {
            Thread workerThread = new Thread(() => SendRequest(request));
            // Start secondary thread  
            workerThread.Start();
        }
    }
}