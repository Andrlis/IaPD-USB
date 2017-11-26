using System;
using System.Collections.Generic;
using System.IO;

using MediaDevices;
using WpdMtpLib;
using USB_Manager.bean;

namespace USB_Manager.resources
{
    class UsbManager
    {
        public static List<Device> GetDeviceList()
        {
            List<Device> answer = new List<Device>();
            foreach (var currentMediaDevice in MediaDevice.GetDevices())
            {
                Device device = new Device();
                try
                {
                    currentMediaDevice.Connect();
                }
                catch (System.IO.DirectoryNotFoundException ex)
                {
                    continue;
                }

                device.Name = currentMediaDevice.FriendlyName;

                if (currentMediaDevice.DeviceType == MediaDevices.DeviceType.Generic)       //If drive name is like a current device name.
                {
                    UsbManager.SetUsbDrive(device);
                }
                else
                {
                    device.Extracted = false;
                    device.Name += " - " + currentMediaDevice.Model;

                    UsbManager.SetMtpDevice(device, currentMediaDevice);
                }
                currentMediaDevice.Disconnect();
                answer.Add(device);
            }
         return answer;
        }

        private static void SetUsbDrive(Device device)
        {
            DriveInfo[] allDrives = DriveInfo.GetDrives();                          //Get names of all logical drives.
            foreach (var currentDriver in allDrives)
            {
                if (currentDriver.DriveType == DriveType.Removable)                 //If drive is removable.
                {
                    if (currentDriver.VolumeLabel == device.Name)
                    {
                        device.TomeName = currentDriver.Name[0];
                        device.Root = currentDriver.RootDirectory;
                        device.TotalMemory = currentDriver.TotalSize;
                        device.FreeMemory = currentDriver.TotalFreeSpace;
                        device.UsedMemory = device.TotalMemory - device.FreeMemory;
                        device.Extracted = true;
                        break;
                    }
                }
            }
        }

        private static void SetMtpDevice(Device device, MediaDevice currentMediaDevice)
        {
            MtpResponse mtpResponse;
            MtpCommand mtpCommand = new MtpCommand();

            string[] deviceIds = mtpCommand.GetDeviceIds();
            if (deviceIds.Length == 0) { return; }

            string targetDeviceId = String.Empty;

            foreach (string deviceId in deviceIds)
            {
                if (currentMediaDevice.FriendlyName.Equals(mtpCommand.GetDeviceFriendlyName(deviceId)))
                {
                    targetDeviceId = deviceId;
                    break;
                }
            }

            if (targetDeviceId.Length == 0) { return; }
            mtpCommand.Open(targetDeviceId);

            uint[] storageIds = null;

            mtpResponse = mtpCommand.Execute(MtpOperationCode.GetStorageIDs, null, null);

            if (mtpResponse != null)
            {
                storageIds = Utils.GetUIntArray(mtpResponse.Data);

                if (storageIds.Length != 0)
                {
                    try
                    {
                        mtpResponse = mtpCommand.Execute(MtpOperationCode.GetStorageInfo, new uint[1] { storageIds[0] }, null);
                        StorageInfo storageInfo = new StorageInfo(mtpResponse.Data);

                        device.TotalMemory = (long)storageInfo.MaxCapacity;
                        device.FreeMemory = (long)storageInfo.FreeSpaceInBytes;
                        device.UsedMemory = device.TotalMemory - device.FreeMemory;
                    }
                    catch
                    {
                        device.TotalMemory = device.FreeMemory = device.UsedMemory = 0;
                    }
                }
            }
        }
    }
}