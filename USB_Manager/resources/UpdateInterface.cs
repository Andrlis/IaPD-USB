using System;
using System.Management;
using System.Windows.Forms;

namespace USB_Manager.resources
{
    class UpdateInterface
    {
        private ManagementEventWatcher ConnectEvent;
        private ManagementEventWatcher DiscnnectEvent;
        Timer Timer;

        public UpdateInterface()
        {
            ConnectEvent = new ManagementEventWatcher(new WqlEventQuery
            {
                EventClassName = "__InstanceCreationEvent",
                WithinInterval = new TimeSpan(0, 0, 2),
                Condition = @"TargetInstance ISA 'Win32_USBControllerdevice'"
            });

            DiscnnectEvent = new ManagementEventWatcher(new WqlEventQuery
            {
                EventClassName = "__InstanceDeletionEvent",
                WithinInterval = new TimeSpan(0, 0, 2),
                Condition = @"TargetInstance ISA 'Win32_USBControllerdevice'  "
            });


            Timer = new Timer
            {
                Interval = (5000)
            };
        }

        public void AddListenerToDiscnnectEvent(EventArrivedEventHandler handler)
        {
            DiscnnectEvent.EventArrived += handler;
        }

        public void AddListenerToConnectEvent(EventArrivedEventHandler handler)
        {
            ConnectEvent.EventArrived += handler;
        }

        public void AddListerenToTimer(EventHandler handler)
        {
            Timer.Tick += handler;
        }

        public void Start()
        {
            DiscnnectEvent.Start();
            ConnectEvent.Start();
            Timer.Start();
        }
    }
}
