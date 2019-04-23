using Meubelen.Domain.Entities.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meubelen.Domain.Entities
{
    public class Address
    {
        
        public string Country { get; set; }
        public string StreetName { get; set; }
        public string StreetNo { get; set; }
        public string PostCode { get; set; }
        public string City { get; set; }

    }
}
