using DataBaseAccess;
using Microsoft.AspNetCore.Mvc;
using BeyzaWeb.ViewModels;
using System.Linq;

namespace BeyzaWeb.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
{
            var productOrderList = (from product in _context.products
                                    join order in _context.orderDetails
                                    on product.ProductID equals order.ProductID
                                    select new ProductOrderViewModel
                                    {
                                        Product = product,
                                        OrderDetail = order
                                    }).Take(10).ToList();
            return View(productOrderList);
}
    }
}
