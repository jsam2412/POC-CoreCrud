using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreCrud.Models
{
    public class ResponseMessage<T>
    {
        public bool Status { get; set; }
        public string Message { get; set; }
        public T Body { get; set; }
    }
}
