namespace FriendlyFireApi.Models
{ 
    public class PlayerResult
    { 
        public int PlayerId { get; set; } 
        public Player Player { get; set; }

        public int SessionId { get; set; }
        public Session Session { get; set; }

        public double Score { get; set; } 
    }
}
