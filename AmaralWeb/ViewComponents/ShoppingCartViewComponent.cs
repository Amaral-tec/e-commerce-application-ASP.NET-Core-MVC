using Amaral.DataAccess.Repository.IRepository;
using Amaral.Utility;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace AmaralWeb.ViewComponents
{
    public class ShoppingCartViewComponent : ViewComponent
    {

        private readonly IUnitOfWork _unitOfWork;
        public ShoppingCartViewComponent(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var claimsIdentity = (ClaimsIdentity)User.Identity;
            var claim = claimsIdentity.FindFirst(ClaimTypes.NameIdentifier);

            if (claim != null)
            {
                if (HttpContext.Session.GetInt32(StaticData.SESSION_CART) == null)
                {
                    HttpContext.Session.SetInt32(StaticData.SESSION_CART,
                    _unitOfWork.ShoppingCart.GetAll(u => u.ApplicationUserId == claim.Value).Count());
                }

                return View(HttpContext.Session.GetInt32(StaticData.SESSION_CART));
            }
            else
            {
                HttpContext.Session.Clear();
                return View(0);
            }
        }
    }
}