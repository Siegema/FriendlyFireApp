using System.Collections.Generic;

namespace FriendlyFireApi.Models
{
    public class Player
    {
        public int PlayerId { get; set; } 
        public string Name { get; set; } 
        public double HighestScore { get; set; }
        public List<PlayerResult> History { get; set; }
    }
}
