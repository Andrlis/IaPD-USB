using System;
using System.Collections.Generic;
using System.Management;
using System.Windows.Forms;

using USB_Manager.resources;
using USB_Manager.bean;

namespace USB_Manager
{
    public partial class Form1 : Form
    {

        private List<Device> Devices;
        private UpdateInterface updateInterface;

        public Form1()
        {
            updateInterface = new UpdateInterface();
            updateInterface.AddListenerToConnectEvent(Refresh);
            updateInterface.AddListenerToDiscnnectEvent(Refresh);
            updateInterface.AddListerenToTimer(new EventHandler(Refresh));

            Devices = UsbManager.GetDeviceList();
            InitializeComponent();
            ViewDevices();

            updateInterface.Start();
        }


        private void Refresh(object sender, EventArrivedEventArgs e)
        {
            ViewDevices();
        }

        private void Refresh(object sender, EventArgs e)
        {
            ViewDevices();
        }

        private void ViewDevices()
        {
            if (!InvokeRequired)
            {
                var temp = UsbManager.GetDeviceList();
                if (!DeviceKeeper.Compare(Devices, temp) || DevisesList.Items.Count == 0)
                {
                    Clear();
                    Devices = temp;
                    foreach (var device in Devices)
                    {
                        DevisesList.Items.Add((device.TomeName == '\0') ? device.Name : (device.TomeName + ": " + device.Name));
                    }
                }
            }
            else
            {
                Invoke(new Action(ViewDevices));
            }
        }

        private void Clear()
        {
            DevisesList.Items.Clear();
            name.Text = "";
            Tom.Text = "";
            total.Text = free.Text = busy.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Click(object sender, EventArgs e)
        {

        }

        private void DevisesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {

                var selectedDevice = Devices[DevisesList.SelectedIndices[0]];

                contextMenuStrip1.Enabled = selectedDevice.Extracted;

                name.Text = selectedDevice.Name;
                Tom.Text = selectedDevice.TomeName.ToString();
                total.Text = ((double)selectedDevice.TotalMemory / (1024 * 1024 * 1024)).ToString().Substring(0, 4) + "  GiB";
                free.Text = ((double)selectedDevice.FreeMemory / (1024 * 1024 * 1024)).ToString().Substring(0, 4) + "  GiB";
                busy.Text = ((double)selectedDevice.TomeName / (1024 * 1024 * 1024)).ToString().Substring(0, 4) + "  GiB";

            }
            catch
            {
                ViewDevices();
            }
        }

        private void DevisesList_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                var selectedDevice = Devices[DevisesList.SelectedIndices[0]];
                System.Diagnostics.Process.Start("explorer.exe", selectedDevice.Root.Name);
            }
            catch
            {
                ViewDevices();
            }
        }

        private void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            try
            {
                var selectedDevice = Devices[DevisesList.SelectedIndices[0]];
                if (!selectedDevice.Eject())
                {
                    MessageBox.Show("Error. Try again");
                }
            }
            catch
            {
                ViewDevices();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
