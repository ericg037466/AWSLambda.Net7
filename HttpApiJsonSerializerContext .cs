using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AWSLambda.Net7
{
    [JsonSerializable(typeof(ProductRequest))]
    public partial class HttpApiJsonSerializerContext : JsonSerializerContext
    {
    }
}
