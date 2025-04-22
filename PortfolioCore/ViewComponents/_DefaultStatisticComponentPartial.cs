using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}