using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Requests_Coursework
{
    public class Request
    {
        public DateTime startTime;
        public DateTime endTime;
        public Request(DateTime startTime, DateTime endTime)
        {
            this.startTime = startTime;
            this.endTime = endTime;
        }
    }
}
