using System;
using System.Collections.Generic;

namespace Project.Models
{
    public partial class PlayersInfo
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public string PlayerRole { get; set; }
        public int? PlayerMatches { get; set; }
    }
}
