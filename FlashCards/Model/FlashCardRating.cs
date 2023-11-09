namespace FlashCards.Model
{
    public class FlashCardRating
    {
        public int Id { get; set; }
        public double Rating { get; set; }
        public int FlashCardId { get; set; }
    }
}
