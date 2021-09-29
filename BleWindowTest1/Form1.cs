using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;
using System.IO;




namespace BleWindowTest1
{
    public partial class Form1 : Form
    {
        List<string> items;
        public Form1()
        {
            items = new List<string>();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (serverStarted)
            {
                updateUI("Server already started silly sausage!");
                return;
            }


            if (rbClient.Checked)
            {
                /*connectAsClient();*/
                startScan();
            }
            else
            {
                connectAsServer();
            }
        }

        private void startScan()
        {
            Thread bluetoothScanThred = new Thread(new ThreadStart(scan));
            bluetoothScanThred.Start();
        }

        BluetoothDeviceInfo[] devices;
        private void scan()
        {
            

            updateUI("Starting Scan..");
            BluetoothClient client = new BluetoothClient();
            devices = client.DiscoverDevicesInRange();
            updateUI("Scan Complete.");
            updateUI(devices.Length.ToString() + " devices discovered");
            foreach(BluetoothDeviceInfo d in devices)
            {
                items.Add(d.DeviceName);
            }

            updateDeviceList();
        }

        private void connectAsServer()
        {
            Thread bluetoothServerThread = new Thread(new ThreadStart(ServerConnectThread));
            bluetoothServerThread.Start();
        }

        private void connectAsClient()
        {
            throw new NotImplementedException();
        }

        /*Guid mUUID = new Guid("00001101-0000-1000-8000-00805F9B34FB");*/
        Guid mUUID = new Guid("6e400002-b5a3-f393-e0a9-e50e24dcca9e");
        bool serverStarted = false;

        public void ServerConnectThread()
        {
            serverStarted = true;
            updateUI("Server started, waiting for clients");

            BluetoothListener blueListener = new BluetoothListener(mUUID);
            blueListener.Start();
            BluetoothClient conn = blueListener.AcceptBluetoothClient();
            updateUI("Client has connected");

            Stream mStream = conn.GetStream();
            while (true)
            {
                try
                {
                    //handel server connection
                    byte[] received = new byte[1024];
                    mStream.Read(received, 0, received.Length);
                    updateUI("Received: " + Encoding.ASCII.GetString(received));
                    byte[] sent = Encoding.ASCII.GetBytes("Hello World");
                    mStream.Write(sent, 0, sent.Length);
                }catch(IOException exception)
                {
                    updateUI("Client has disconnected!!!!");
                }
            }
        }

        private void updateUI(string message)
        {
            Func<int> del = delegate ()
            {
                tbOutput.AppendText(message + System.Environment.NewLine);
                return 0;
            };
            Invoke(del);
        }

        private void updateDeviceList()
        {
            Func<int> del = delegate ()
            {
                listBox1.DataSource = items;
                return 0;
            };
            Invoke(del);
        }

        BluetoothDeviceInfo deviceInfo;
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            deviceInfo = devices.ElementAt(listBox1.SelectedIndex);
            updateUI(deviceInfo.DeviceName + " was selected, attempting connect ");

            if (pairDevice())
            {
                updateUI("device paired..");
                updateUI("starting connect thread");
                Thread bluetoothClientThread = new Thread(new ThreadStart(ClientConnectThread));
                bluetoothClientThread.Start();
            }
            else
            {
                updateUI("Pair failed");
            }
        }

        private void ClientConnectThread()
        {
            BluetoothClient client = new BluetoothClient();
            updateUI("attempting connect");
            client.BeginConnect(deviceInfo.DeviceAddress, mUUID,this.BluetoothClientConnectCallback, client);

        }

        void BluetoothClientConnectCallback(IAsyncResult result)
        {
            BluetoothClient client = (BluetoothClient)result.AsyncState;
            client.EndConnect(result);

            Stream stream = client.GetStream();
            stream.ReadTimeout = 1000;

            while (true)
            {
                while (!ready) ;

                stream.Write(message, 0, message.Length);
            }
        }

        string myPin = "0000";
        private bool pairDevice()
        {
            if (!deviceInfo.Authenticated)
            {
                if(!BluetoothSecurity.PairRequest(deviceInfo.DeviceAddress, myPin))
                {
                    return false;
                }
            }
            return true;
        }

        bool ready = false;
        byte[] message;

        private void tbText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
            {
                message = Encoding.ASCII.GetBytes(tbText.Text);
                ready = true;
                tbText.Clear();
            }
        }
    }
}
