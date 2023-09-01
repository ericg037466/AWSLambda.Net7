using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AWSLambda.Net7
{
    public class ProductRequest
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
    }
}
