using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCricket.Domain
{
    public class Fixture
    {
        public DateTime MatchDate { get; set; }
        public Team HomeTeam { get; set; }
        public Team AwayTeam { get; set; }
        public Venue Venue { get; set; }
    }
}
