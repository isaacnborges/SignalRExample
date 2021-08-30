using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SignalRWebApp.Pages
{
    public class OrderModel : PageModel
    {
        private readonly ILogger<OrderModel> _logger;

        public OrderModel(ILogger<OrderModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}
