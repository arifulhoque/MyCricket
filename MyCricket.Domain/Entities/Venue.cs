using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace MyCricket.Domain
{
    public class Venue
    {
        public int Id { get; set; }
        public Address Address { get; set; }
        public bool CurrentRecord { get; set; }
    }
}
