namespace FlashCards.Model
{
    public class FlashCard
    {
        public int Id { get; set; }
        public string? Explanation { get; set; }
        public string? Question { get; set; }
        public string? Right_Answer { get; set; }
        public string? Wrong_Answer1 { get; set; }
        public string? Wrong_Answer2 { get; set; }
        public string? Wrong_Answer3 { get; set; }
        public string? Course_Id { get; set; }
    }
}
