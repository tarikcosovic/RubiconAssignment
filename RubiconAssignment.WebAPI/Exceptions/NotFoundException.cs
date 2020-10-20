using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RubiconAssignment.WebAPI.Exceptions
{
    public class NotFoundException : Exception
    {
        public NotFoundException(string id) : base("Resource not found! id: " + id)
        {

        }
    }
}
