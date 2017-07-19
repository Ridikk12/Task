using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie.ViewModels;
using Zadanie.ViewModels.Abstract;

namespace Zadanie.ModelHelpers
{
    public interface IMediaModelHelper
    {
		List<ElectricityViewModel> GetElectricityViewModelList();
		List<HeatViewModel> GetHeatViewModelList();
	}
}
