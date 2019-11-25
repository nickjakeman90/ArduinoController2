using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArduinoController
{
    public class LED
    {

        public LED() {
        }

        public LED(int id, bool active)
        {
            LEDID = id;
            Active = active;
        }

        public LED(int id, bool active, int pid)
        {
            LEDID = id;
            Active = active;
            PortID = pid;

        }
        
        public int LEDID { get; set; }
        public int PortID { get; set; }
        public bool Active { get; set; }

    }
}
