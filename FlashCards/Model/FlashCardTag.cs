namespace FlashCards.Model
{
    public class FlashCardTag
    {
        public int Id { get; set; }
        public string? Tag { get; set; }
        public int FlashCardId { get; set; }
    }
}
