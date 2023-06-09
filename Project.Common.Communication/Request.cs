using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Common.Communication
{
    public class Request
    {
        public Operation Operation { get; set; }
        public object RequestObject { get; set; }
    }
}
