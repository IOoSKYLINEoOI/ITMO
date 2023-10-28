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
            MessageRezult = "��� ������ ����� ���������� ������";
        }
        public void OnPost(string name, decimal? price)
        {
            Product = new Product();
            var result = price * (decimal?)0.18;
            MessageRezult = $"��� ������ {name} � ����� {price} ������ ��������� {result}";
            Product.Price = price;
            Product.Name = name;
        }
    }
}
