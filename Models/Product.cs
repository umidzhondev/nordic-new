namespace Nordic.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Category { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public decimal? OriginalPrice { get; set; }
    public double Rating { get; set; }
    public int ReviewsCount { get; set; }
    public string Image { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string? Badge { get; set; } // "Sale", "New", "Top" yoki null
    public bool InStock { get; set; } = true;
    public List<string> Dimensions { get; set; } = new();
    public string Material { get; set; } = string.Empty;
}