using MongoDB.Entities;

namespace SearchService.Models
{
    public class Item : Entity
    {
        public int ReservePrice { get; set; }
        public string Seller { get; set; }
        public string Winner { get; set; }
        public int SoldAmount { get; set; }
        public int CurrentHighBid { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime AuctionEnd { get; set; }
        public string Status { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Medium { get; set; }
        public string Category { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string ImageUrl { get; set; }
    }
}
