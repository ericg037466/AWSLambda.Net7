using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambda.Net7
{
    public class ProductResponse : ProductRequest
    {
        public string ResultCode { get; set; }
        public string ResultMsg { get; set; }
    }
}
