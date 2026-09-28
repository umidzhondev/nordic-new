using Nordic.Models;

namespace Nordic.Services;

public class ProductService
{
    public static readonly List<string> Categories = new()
    {
        "Все",
        "Мебель",
        "Освещение",
        "Текстиль",
        "Декор"
    };

    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Кресло Lounge Minimalist",
                Price = 340,
                OriginalPrice = 420,
                Category = "Мебель",
                Badge = "Sale",
                Rating = 4.9,
                ReviewsCount = 18,
                Image = "https://images.unsplash.com/photo-1567538096630-e0c55bd6374c?auto=format&fit=crop&q=80&w=800",
                Description = "Лаконичное кресло с обивкой из натурального букле и массивом дуба."
            },
            new Product
            {
                Id = 2,
                Name = "Светильник Paper Shade",
                Price = 115,
                Category = "Освещение",
                Badge = "New",
                Rating = 4.7,
                ReviewsCount = 9,
                Image = "https://images.unsplash.com/photo-1507473885765-e6ed057f782c?auto=format&fit=crop&q=80&w=800",
                Description = "Напольный светильник из рисовой бумаги в японско-скандинавском стиле."
            },
            new Product
            {
                Id = 3,
                Name = "Ваза Ceramic Silhouette",
                Price = 65,
                Category = "Декор",
                Badge = "Top",
                Rating = 5.0,
                ReviewsCount = 32,
                Image = "https://images.unsplash.com/photo-1578749556568-bc2c40e68b61?auto=format&fit=crop&q=80&w=800",
                Description = "Керамическая ваза ручной работы с матовой шершавой текстурой."
            },
            new Product
            {
                Id = 4,
                Name = "Плед Linen Warm Touch",
                Price = 85,
                OriginalPrice = 105,
                Category = "Текстиль",
                Badge = "Sale",
                Rating = 4.8,
                ReviewsCount = 14,
                Image = "https://images.unsplash.com/photo-1584100936595-c0654b55a2e2?auto=format&fit=crop&q=80&w=800",
                Description = "100% льняной плед природного бежевого оттенка с мягкой бахромой."
            },
            new Product
            {
                Id = 5,
                Name = "Стол Oak Coffee",
                Price = 260,
                Category = "Мебель",
                Rating = 4.6,
                ReviewsCount = 11,
                Image = "https://images.unsplash.com/photo-1533090161767-e6ffed986c88?auto=format&fit=crop&q=80&w=800",
                Description = "Журнальный столик из беленого дуба с округлыми органическими формами."
            },
            new Product
            {
                Id = 6,
                Name = "Подсвечник Brass Pillar",
                Price = 45,
                Category = "Декор",
                Badge = "New",
                Rating = 4.9,
                ReviewsCount = 7,
                Image = "https://images.unsplash.com/photo-1603006905003-be475563bc59?auto=format&fit=crop&q=80&w=800",
                Description = "Латунный подсвечник с патиной для высоких столовых свечей."
            },
            new Product
            {
                Id = 7,
                Name = "Люстра Glass Sphere",
                Price = 210,
                Category = "Освещение",
                Badge = "Top",
                Rating = 4.8,
                ReviewsCount = 21,
                Image = "https://images.unsplash.com/photo-1513506003901-1e6a229e2d15?auto=format&fit=crop&q=80&w=800",
                Description = "Подвесная люстра с шарами из матового стекла на латунном каркасе."
            },
            new Product
            {
                Id = 8,
                Name = "Подушка Wool Cushion",
                Price = 55,
                Category = "Текстиль",
                Rating = 4.7,
                ReviewsCount = 15,
                Image = "https://images.unsplash.com/photo-1584100936595-c0654b55a2e2?auto=format&fit=crop&q=80&w=800",
                Description = "Декоративная подушка из шерстяного меланжа в стиле уаби-саби."
            },
            new Product
            {
                Id = 9,
                Name = "Стеллаж Nordic Frame",
                Price = 410,
                OriginalPrice = 480,
                Category = "Мебель",
                Badge = "Sale",
                Rating = 4.9,
                ReviewsCount = 28,
                Image = "https://images.unsplash.com/photo-1594620302200-9a762244a156?auto=format&fit=crop&q=80&w=800",
                Description = "Открытый стеллаж из ясеня для книг и предметов искусства."
            },
            new Product
            {
                Id = 10,
                Name = "Зеркало Arc Wall Mirror",
                Price = 130,
                Category = "Декор",
                Badge = "New",
                Rating = 4.8,
                ReviewsCount = 19,
                Image = "https://images.unsplash.com/photo-1618221195710-dd6b41faaea6?auto=format&fit=crop&q=80&w=800",
                Description = "Настенное зеркало с арочным верхом в тонкой металлической раме."
            },
            new Product
            {
                Id = 11,
                Name = "Бра Minimal Tube",
                Price = 95,
                Category = "Освещение",
                Rating = 4.5,
                ReviewsCount = 8,
                Image = "https://images.unsplash.com/photo-1507473885765-e6ed057f782c?auto=format&fit=crop&q=80&w=800",
                Description = "Лаконичный настенный светильник с мягким рассеянным светом."
            },
            new Product
            {
                Id = 12,
                Name = "Ковер Soft Sand",
                Price = 290,
                Category = "Текстиль",
                Badge = "Top",
                Rating = 5.0,
                ReviewsCount = 40,
                Image = "https://images.unsplash.com/photo-1600121848594-d8644e57abab?auto=format&fit=crop&q=80&w=800",
                Description = "Ковер ручной работы из новозеландской шерсти песчаного оттенка."
            },
            new Product
            {
                Id = 13,
                Name = "Пуф Bouclé Round",
                Price = 140,
                Category = "Мебель",
                Rating = 4.7,
                ReviewsCount = 16,
                Image = "https://images.unsplash.com/photo-1567538096630-e0c55bd6374c?auto=format&fit=crop&q=80&w=800",
                Description = "Круглый пуф в текстурной ткани букле цвета слоновой кости."
            },
            new Product
            {
                Id = 14,
                Name = "Кашпо Stone Texture",
                Price = 50,
                Category = "Декор",
                Rating = 4.6,
                ReviewsCount = 12,
                Image = "https://images.unsplash.com/photo-1485955900006-10f4d324d411?auto=format&fit=crop&q=80&w=800",
                Description = "Каменное кашпо для суккулентов и комнатных растений."
            },
            new Product
            {
                Id = 15,
                Name = "Настольная лампа Concrete",
                Price = 125,
                OriginalPrice = 150,
                Category = "Освещение",
                Badge = "Sale",
                Rating = 4.8,
                ReviewsCount = 23,
                Image = "https://images.unsplash.com/photo-1513506003901-1e6a229e2d15?auto=format&fit=crop&q=80&w=800",
                Description = "Светильник с бетонным основанием и льняным абажуром."
            },
            new Product
            {
                Id = 16,
                Name = "Скатерть Natural Cotton",
                Price = 70,
                Category = "Текстиль",
                Badge = "New",
                Rating = 4.9,
                ReviewsCount = 10,
                Image = "https://images.unsplash.com/photo-1584100936595-c0654b55a2e2?auto=format&fit=crop&q=80&w=800",
                Description = "Праздничная хлопковая скатерть ненавязчивого теплого оттенка."
            }
        };
    }
}