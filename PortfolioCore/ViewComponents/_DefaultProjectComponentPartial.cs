using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultProjectComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var portfolios = context.Portfolios.Include(p => p.Category).ToList();
            return View(portfolios);
        }
    }
}