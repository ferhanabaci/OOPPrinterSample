using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPPrinterSample
{
    internal class Printer
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        //public bool IsOpen { get; set; }
        public Status status { get; set; }
    }
}
