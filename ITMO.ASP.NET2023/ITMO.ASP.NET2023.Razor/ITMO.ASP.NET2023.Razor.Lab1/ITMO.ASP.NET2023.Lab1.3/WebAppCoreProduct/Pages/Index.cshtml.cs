using Microsoft.AspNetCore.Mvc.RazorPages;
using WebAppCoreProduct.Models;

namespace WebAppCoreProduct.Pages
{
    public class IndexModel : PageModel
    {
        public Product Product { get; set; }
        public string? MessageRezult { get; private set; }
        public void OnGet()
        {
            MessageRezult = "Для товара можно определить скидку";
        }
        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            var result = price * (decimal?)0.18;
            MessageRezult = $"Для товара {name} с ценой {price} скидка получится {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
