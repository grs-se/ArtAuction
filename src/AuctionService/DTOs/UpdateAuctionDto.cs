namespace AuctionService.DTOs
{
    public class UpdateAuctionDto
    {
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Medium { get; set; }
        public string Category { get; set; }
        public int? Year { get; set; }
        public string Color { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
    }
}
