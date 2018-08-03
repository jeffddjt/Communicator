using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace Dysoft.Utils.Communicator
{
    public class HTTPState
    {
        public HttpWebRequest Request { get; set; }
        public byte[] Data { get; set; }
        public HTTPState(HttpWebRequest request, byte[] data)
        {
            this.Request = request;
            this.Data = data;
        }
    }
}
