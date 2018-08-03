using System;
using System.Collections.Generic;
using System.Text;

namespace Dysoft.Utils.Communicator
{
    public delegate void ReceiveDelegate(byte[] buf);
    public delegate void ErrorDelegate(string msg);
    public delegate void NotifyDelegate(string msg);
    public delegate void ConnectedDelegate();
}
