using System.ComponentModel.DataAnnotations;

namespace PieceOfArtProject.Models
{
    public class LoyaltyCard
    {
        public int Id { get; set; }

        [Required]
        public string CardNumber { get; set; }

        [Range(0, double.MaxValue)]
        public decimal Balance { get; set; }

        public int CustomerId { get; set; }
        public Cutomer Customer { get; set; }
    }
}
