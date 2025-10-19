using System.ComponentModel.DataAnnotations;

namespace PieceOfArtProject.Models
{
    public class Category
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public ICollection<ArtPiece> ArtPiece { get; set; }
    }
}
