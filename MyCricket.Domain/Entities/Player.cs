using System;

namespace MyCricket.Domain
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GenderEnum Gender { get; set; }
        public DateTime JoinedDate { get; set; }
    }
}
