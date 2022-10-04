using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Movie.Domain.Identity;
using System.Security.Claims;
using Movie.Service.Interface;
using System;
using GemBox.Document;
using System.IO;
using System.Text;
using Microsoft.AspNetCore.Authorization;

namespace Movie.Web.Controllers
{
    [Authorize(Roles = "Administrators, Users")]
    public class OrderController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly UserManager<MovieUsers> _userManager;

        public OrderController(IOrderService orderService, UserManager<MovieUsers> userManager)
        {
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");
            _orderService = orderService;
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            return View(this._orderService.GetAllOrdersByUser(userId));
        }

        public FileContentResult CreateInvoice(Guid id)
        {
            var order = this._orderService.GetOrderDetailsById(id); 

            var templatePath = Path.Combine(Directory.GetCurrentDirectory(), "Invoice.docx");
            var document = DocumentModel.Load(templatePath);

            document.Content.Replace("{{OrderNumber}}", order.Id.ToString());
            document.Content.Replace("{{CustomerDetails}}", order.User.FirstName + " " + order.User.LastName);

            var totalPrice = 0;
            StringBuilder sb = new StringBuilder();
            foreach (var item in order.FilmInOrders)
            {
                sb.AppendLine("Movie name: " + item.SelectedFilm.Name + " Quantity: " + item.Kvalitet + " Total price:" + item.SelectedFilm.Price * item.Kvalitet + "$");
                totalPrice += item.SelectedFilm.Price * item.Kvalitet;
            }

            document.Content.Replace("{{MoviesInOrder}}", sb.ToString());
            document.Content.Replace("{{TotalPrice}}", totalPrice.ToString() + "$");
            document.Content.Replace("{{OrderDate}}", order.Created.ToShortDateString());

            var stream = new MemoryStream();

            document.Save(stream, new DocxSaveOptions());

            return File(stream.ToArray(), new DocxSaveOptions().ContentType, "ExportInvoice.docx");
        }
    }
}
