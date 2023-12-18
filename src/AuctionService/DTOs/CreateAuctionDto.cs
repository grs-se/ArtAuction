using System.ComponentModel.DataAnnotations;

namespace AuctionService.DTOs
{
    public class CreateAuctionDto
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Medium { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string Color { get; set; }
        [Required]
        public int Height { get; set; }
        [Required]
        public int Width { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public int ReservePrice { get; set; }
        [Required]
        public DateTime AuctionEnd { get; set; }
    }
}
