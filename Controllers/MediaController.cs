using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Zadanie.ViewModels;
using Zadanie.ViewModels.Abstract;
using Zadanie.ModelHelpers;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Zadanie.Controllers
{

	public class MediaController : Controller
    {
		private readonly IMediaModelHelper _modelHelper;
		public MediaController(IMediaModelHelper modelHelper)
		{
			_modelHelper = modelHelper;
		}

        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetElectricity()
        {
			List<ElectricityViewModel> vm = _modelHelper.GetElectricityViewModelList();
			return Json(vm);
        }

		public JsonResult GetHeat()
		{
			List<HeatViewModel> vm = _modelHelper.GetHeatViewModelList();
			return Json(vm);
		}
	}
}
