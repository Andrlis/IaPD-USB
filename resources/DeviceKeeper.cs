using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace USB_Manager.resources
{
    class DeviceKeeper
    {

        public static bool Compare(List<USB_Manager.bean.Device> devList1, List<USB_Manager.bean.Device> devList2)
        {
            if(devList1 == null || devList2 == null || devList1.Count != devList2.Count)
            {
                return false;
            }

            for(int i = 0; i < devList1.Count; i++)
            {
                if(!devList1.ElementAt(i).Equals(devList2.ElementAt(i)))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
