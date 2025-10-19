using System.ComponentModel.DataAnnotations;

namespace PieceOfArtProject.Models
{
    public class Cutomer
    {
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string Phone { get; set; }

        public ICollection<ArtPiece> ArtPieces { get; set; }
        public LoyaltyCard LoyaltyCard { get; set; }
    }
}
