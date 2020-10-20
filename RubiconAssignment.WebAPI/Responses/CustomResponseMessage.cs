using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Filters
{
    public class CustomResponseMessage
    {
        public int Status { get; set; }
        public string Error { get; set; }
        public string Message { get; set; }
        public string Timestamp { get; set; }
        public CustomResponseMessage()
        {
            Timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
        }
        public CustomResponseMessage(int status, string error, string message, string url)
        {
            Timestamp = DateTime.Now.ToString("yyyyMMddHHmmssffff");
            Status = status;
            Error = error;
            Message = message;
        }
    }
}
