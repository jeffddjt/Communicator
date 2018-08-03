using System;
using System.Collections.Generic;
using System.Text;

namespace Dysoft.Utils.Communicator
{
    public class DyEventArgs : EventArgs
    {
        public string Message { get; set; }
        public byte[] Data { get; set; }
    }
}
