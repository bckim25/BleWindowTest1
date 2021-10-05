using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using Windows.Devices.Bluetooth;
using Windows.Devices.Bluetooth.GenericAttributeProfile;
using Windows.Devices.Enumeration;


namespace BleWindowTest1
{
    public partial class Form1 : Form
    {
        List<string> items;
        static DeviceInformation device = null;

        public Form1()
        {
            items = new List<string>();
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {

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

        private async Task show()
        {
            // Query for extra properties you want returned
            string[] requestedProperties = { "System.Devices.Aep.DeviceAddress", "System.Devices.Aep.IsConnected" };

            DeviceWatcher deviceWatcher =
                        DeviceInformation.CreateWatcher(
                                BluetoothLEDevice.GetDeviceSelectorFromPairingState(false),
                                requestedProperties,
                                DeviceInformationKind.AssociationEndpoint);

            // Register event handlers before starting the watcher.
            // Added, Updated and Removed are required to get all nearby devices
            deviceWatcher.Added += DeviceWatcher_Added;
            deviceWatcher.Updated += DeviceWatcher_Updated;
            deviceWatcher.Removed += DeviceWatcher_Removed;

            // EnumerationCompleted and Stopped are optional to implement.
            deviceWatcher.EnumerationCompleted += DeviceWatcher_EnumerationCompleted;
            deviceWatcher.Stopped += DeviceWatcher_Stopped;

            // Start the watcher.
            deviceWatcher.Start();
            while (true)
            {
                if (device == null)
                {
                    Thread.Sleep(500);
                }
                else
                {
                    Console.WriteLine("PRess Any to pair with Wahoo Ticker");
                    Console.ReadKey();
                    BluetoothLEDevice bluetoothLeDevice = await BluetoothLEDevice.FromIdAsync(device.Id);
                    Console.WriteLine("Attempting to pair with device");
                    GattDeviceServicesResult result = await bluetoothLeDevice.GetGattServicesAsync();

                    if (result.Status == GattCommunicationStatus.Success)
                    {
                        Console.WriteLine("Pairing succeeded");
                        var services = result.Services;
                        foreach (var service in services)
                        {
                            Console.WriteLine(service.Uuid);
                        }
                    }
                    Console.WriteLine("Press Any Key to Exit application");
                    Console.ReadKey();
                    break;
                }

            }
        }


        private void scan()
        {
            updateUI("Starting Scan..");
            items.Clear();

            this.show();



            /*devices = client.DiscoverDevicesInRange();


            updateUI("Scan Complete.");
            updateUI(devices.Length.ToString() + " devices discovered");
            string deviceName;
            string connected;
            string rssi;
            string deviceAddr;

            foreach (BluetoothDeviceInfo d in devices)
            {
                deviceName = d.DeviceName;
                connected = d.Connected.ToString();
                rssi = d.Rssi.ToString();
                deviceAddr = d.DeviceAddress.ToString();

                items.Add(d.DeviceName + "(" + connected + ")" + " - addr: " + deviceAddr);
                Console.WriteLine("★★★ items : " + d.DeviceName);
            }*/




            updateDeviceList();
        }

        private void DeviceWatcher_Stopped(DeviceWatcher sender, object args)
        {
            throw new NotImplementedException();
        }

        private void DeviceWatcher_EnumerationCompleted(DeviceWatcher sender, object args)
        {
            throw new NotImplementedException();
        }

        private void DeviceWatcher_Removed(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            throw new NotImplementedException();
        }

        private void DeviceWatcher_Updated(DeviceWatcher sender, DeviceInformationUpdate args)
        {
            throw new NotImplementedException();
        }

        private void DeviceWatcher_Added(DeviceWatcher sender, DeviceInformation args)
        {
            if(args.Name == "Nugawinder")
            {
                items.Add(args.Name);
            }


            //throw new NotImplementedException();
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

        

        public void ServerConnectThread()
        {
           
            updateUI("Server started, waiting for clients");

            updateUI("Client has connected");

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

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }




        string myPin = "0000";


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
