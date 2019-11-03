using System.Collections.Generic;

namespace FriendlyFireApi.Models
{ 
    public class Session
    {
        public int SessionId { get; set; } 
        public int Kills { get; set; }
        public int Waves { get; set; }
        public double Score { get; set; } 

        //Player and their contributing score
        public List<PlayerResult> Results { get; set; } 
    }
}
