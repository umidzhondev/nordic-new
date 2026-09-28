using Nordic.Models;

namespace Nordic.Services;

public class CartItem
{
    public Product Product { get; set; } = default!;
    public int Quantity { get; set; } = 1;
}

public class CartService
{
    public List<CartItem> Items { get; private set; } = new();
    
    // UI yangilanishini xabar qilish uchun event
    public event Action? OnChange;

    public decimal TotalPrice => Items.Sum(i => i.Product.Price * i.Quantity);
    public int TotalCount => Items.Sum(i => i.Quantity);

    public void AddToCart(Product product)
    {
        var existingItem = Items.FirstOrDefault(i => i.Product.Id == product.Id);
        if (existingItem != null)
        {
            existingItem.Quantity++;
        }
        else
        {
            Items.Add(new CartItem { Product = product, Quantity = 1 });
        }
        NotifyStateChanged();
    }

    public void RemoveFromCart(int productId)
    {
        Items.RemoveAll(i => i.Product.Id == productId);
        NotifyStateChanged();
    }

    public void UpdateQuantity(int productId, int quantity)
    {
        if (quantity <= 0)
        {
            RemoveFromCart(productId);
            return;
        }

        var item = Items.FirstOrDefault(i => i.Product.Id == productId);
        if (item != null)
        {
            item.Quantity = quantity;
            NotifyStateChanged();
        }
    }

    public void ClearCart()
    {
        Items.Clear();
        NotifyStateChanged();
    }

    private void NotifyStateChanged() => OnChange?.Invoke();
}