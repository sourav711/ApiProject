using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.RequestModels
{
    public class PlayerRequest
    {
      
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public string PlayerRole { get; set; }
        public int? PlayerMatches { get; set; }
    }
}
