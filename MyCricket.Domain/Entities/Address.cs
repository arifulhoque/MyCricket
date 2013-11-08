using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCricket.Domain
{
    public class Address
    {
        public int Id { get; set; }
        public string Suite { get; set; }
        public string AddressLines { get; set; }
        public string Suburb { get; set; }
        public string PostCode { get; set; }
        public State State { get; set; }
        public Country Country { get; set; }
        public decimal? Latitude { get; set; }
        public decimal? Longitude { get; set; }
    }
}
