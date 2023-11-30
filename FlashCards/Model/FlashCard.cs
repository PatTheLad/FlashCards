namespace FlashCards.Model
{
    public class FlashCard
    {
        public int Id { get; set; }
        public string? Explanation { get; set; }
        public string? Question { get; set; }
        public string? RightAnswer { get; set; }
        public List<string> Tags { get; set; } = new();
        public string? WrongAnswer1 { get; set; }
        public string? WrongAnswer2 { get; set; }
        public string? WrongAnswer3 { get; set; }
    }
}
