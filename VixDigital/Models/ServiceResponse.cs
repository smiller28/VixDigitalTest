using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VixDigital.Models
{
    public class ServiceResponse
    {
        public int Id { get; set; }
        public string Service { get; set; }
        public string Status { get; set; }
        public string Server { get; set; }
        public string MethodType { get; set; }
        public string ContentType { get; set; }
        public DateTime ServiceLastModified { get; set; }
        public DateTime LastUpdated { get; set; }
    }
}
