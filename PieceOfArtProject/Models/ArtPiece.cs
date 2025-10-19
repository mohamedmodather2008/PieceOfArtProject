using System.ComponentModel.DataAnnotations;

namespace PieceOfArtProject.Models
{
    public class ArtPiece
    {
        public int Id { get; set; }

        [Required, MaxLength(150)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; }

        [Required, Range(0.01, double.MaxValue)]
        public decimal Price { get; set; }

        public int CustomerId { get; set; }
        public Cutomer Customer { get; set; }

        public ICollection<Category> Categories { get; set; }
    }
}
