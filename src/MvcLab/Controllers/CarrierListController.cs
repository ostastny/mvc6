namespace MyShuttle.Web.Controllers
{
    using Data;
    using Microsoft.AspNet.Mvc;
    using Microsoft.AspNet.Mvc.ViewFeatures;
    using Model;
    using Models;
    using System.Threading.Tasks;

    public class CarrierListController : Controller
    {
        private ICarrierRepository _carrierRepository;

        public CarrierListController(ICarrierRepository carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }

        public async Task<IActionResult> Index(SearchViewModel searchVM)
        {
            string searchString = searchVM == null ? null : searchVM.SearchString;
            var carriers = await _carrierRepository.GetCarriersAsync(searchString);
            var model = new CarrierListViewModel(carriers);
            return View("Index", model);
        }

    }
}

