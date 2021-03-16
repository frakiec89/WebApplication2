using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2
{
    public class  POSTin
    {
        public string patient { get; set; }
        public List<service> services { get; set; }

    }

    public class GETiout
    {
        public string patient { get; set; }
        public List<service> services { get; set; }

    }

    public class service
    {
        public int сode { get; set; }
        public string result { get; set; }
    }

    public class GETStatus
    {
        public int progress { get; set; }
    }
}
