using BusinessLayer.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace FitOnBlog.ViewComponents
{
    public class ContactAddressPartial : ViewComponent
    {
        private readonly IAddressService _addressService;
        public ContactAddressPartial(IAddressService addressService)
        {
            _addressService = addressService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _addressService.GetListAll();

            return View(values);
        }
    }
}
