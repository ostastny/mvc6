using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.ViewFeatures;
using MyShuttle.Models;
using MyShuttle.Data;
using MyShuttle.Model;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcLab
{
    public class HomeController : Controller
    {
        [ViewDataDictionary]
        public ViewDataDictionary tempViewData { get; set; }

        private ICarrierRepository _carrierRepository;

        public HomeController(ICarrierRepository carrierRepository)
        {
            _carrierRepository = carrierRepository;
        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            tempViewData.Model = new MyShuttleViewModel()
            {
                MainMessage = "The Ultimate B2B Shuttle Service Solution"
            };
            return new ViewResult() { ViewData = tempViewData };
        }

        [HttpPost]
        public async Task<int> Post([FromBody]Carrier carrier)
        {
            return await _carrierRepository.AddAsync(carrier);
        }


    }
}
