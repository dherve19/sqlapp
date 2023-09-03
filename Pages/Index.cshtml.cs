using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Models;
using Services;

namespace MyWebApp.Pages
{ 
    public class IndexModel : PageModel
    {
        public List<Product>? Products; 
        public void OnGet()
        {
            ProductService productService = new ProductService();
            Products= productService.GetProducts();

        }
    }
}