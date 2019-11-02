namespace FriendlyFireApi.Models
{ 
    public class Session
    {
        public int[] PlayerCount { get; set; }
        public Player[] players { get; set; }
        public int ID { get; set; }
    }
}
