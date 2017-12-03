using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UsbEject;

namespace USB_Manager.bean
{
    class Device
    {
        private string name;
        private char tomeName;
        private long totalMemory;
        private long usedMemory;
        private long freeMemory;
        private DirectoryInfo root;
        private bool extracted;

        public Device() { }

        public Device(string name, char tomName, long totalMemory, 
            long usedMemory, long freeMemory, DirectoryInfo root) {
            this.name = name;
            this.tomeName = tomName;
            this.totalMemory = totalMemory;
            this.freeMemory = freeMemory;
            this.usedMemory = usedMemory;
            this.root = root;
        }
        
        public string Name
        {
            get { return name; }
            set { this.name = value; }
        }

        public char TomeName
        {
            get { return tomeName; }
            set { this.tomeName = value; }
        }

        public long TotalMemory
        {
            get { return totalMemory; }
            set { this.totalMemory = value; }
        }

        public long FreeMemory
        {
            get { return freeMemory; }
            set { this.freeMemory  = value; }
        }

        public long UsedMemory
        {
            get { return this.usedMemory; }
            set { this.usedMemory = value; }
        }

        public DirectoryInfo Root
        {
            get { return this.root; }
            set { this.root = value; }
        }

        public bool Extracted
        {
            get { return this.extracted; }
            set { this.extracted = value; }
        }

        public bool Eject()
        {
            if (!extracted)
            {
                return false;
            }

            VolumeDeviceClass volumeDeviceClass = new VolumeDeviceClass();
            foreach (Volume dev in volumeDeviceClass.Devices)
            {
                try
                {
                    if (dev.LogicalDrive.Equals(this.tomeName + ":"))
                    {
                        dev.Eject(true);
                        volumeDeviceClass = new VolumeDeviceClass();
                        foreach (Volume temp in volumeDeviceClass)
                        {
                            if (temp.LogicalDrive.Equals(this.tomeName + ":"))
                                return false;
                        }
                        return true;
                    }
                }
                catch
                {
                    break;
                }
            }

            return false;
        }

        public override bool Equals(object obj)
        {
            var device = obj as Device;
            return device != null &&
                   name == device.name &&
                   tomeName == device.tomeName &&
                   totalMemory == device.totalMemory &&
                   usedMemory == device.usedMemory &&
                   freeMemory == device.freeMemory &&
                   EqualityComparer<DirectoryInfo>.Default.Equals(root, device.root) &&
                   extracted == device.extracted;
        }

        public override int GetHashCode()
        {
            var hashCode = 1884607264;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(name);
            hashCode = hashCode * -1521134295 + tomeName.GetHashCode();
            hashCode = hashCode * -1521134295 + totalMemory.GetHashCode();
            hashCode = hashCode * -1521134295 + usedMemory.GetHashCode();
            hashCode = hashCode * -1521134295 + freeMemory.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<DirectoryInfo>.Default.GetHashCode(root);
            hashCode = hashCode * -1521134295 + extracted.GetHashCode();
            return hashCode;
        }
    }
}
