namespace FlashCards.Model
{
    public class User
    {
        public int Id { get; set; }
        public string? UserName { get; set; }
        public string? Password { get; set; }
        public string? Email { get; set; }
        public string? Game { get; set; }
        public int Lobby { get; set; }
        public string? AdminCommand { get; set; }
        public double Score { get; set; }
        public bool Finished { get; set; }
    }
}
