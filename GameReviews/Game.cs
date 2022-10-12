using System.ComponentModel.DataAnnotations;

namespace GameReviews
{
    public class Game
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Producer { get; set; }
        public string Description { get; set; }
        [RangeAttribute(1.0, 10.0, ErrorMessage = "Value for Rating must be between 1.0 and 10.0.")]
        public float Rating { get; set; }
        [RangeAttribute(1.0, 10.0, ErrorMessage = "Value for Rating must be between 1.0 and 10.0.")]
        public float CriticsRating { get; set; }
        public List<Comment> Comments { get; set; }
        public byte[] Image;
        public DateTime Premiere { get; set; }
    }
}
