using AuctionService.Entities;
using System.ComponentModel.DataAnnotations.Schema;

namespace AuctionService;

[Table("Items")]
public class Item
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    // Brand = Artist
    public string Brand { get; set; }
    public string Medium { get; set; }
    public string Category { get; set; }
    public int Year { get; set; }
    public string Color { get; set; }
    public int Height { get; set; }
    public int Width { get; set; }
    public string ImageUrl { get; set; }

    // nav properties
    public Auction Auction { get; set; }
    public Guid AuctionId { get; set; }
}
