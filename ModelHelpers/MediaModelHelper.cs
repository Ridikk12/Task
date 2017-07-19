using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Zadanie.ViewModels;
using Zadanie.ViewModels.Abstract;

namespace Zadanie.ModelHelpers
{
	public class MediaModelHelper : IMediaModelHelper
	{

		private readonly Random _randomSeed = new Random();


		public List<ElectricityViewModel> GetElectricityViewModelList()
		{
			List<ElectricityViewModel> vm = new List<ElectricityViewModel>();
			int recordCount = _randomSeed.Next(1, 10);

			for (int i = 0; i < recordCount; i++)
			{
				ElectricityViewModel vmEntity = new ElectricityViewModel();
				vmEntity.HouseType = GetHouseType(i);
				vmEntity.Name = "Ele " + i;
				vmEntity.Price = i * 10;
				vm.Add(vmEntity);
			}

			return vm;
		}

		private HouseType GetHouseType(int i)
		{
			if (i % 3 == 0)
				return HouseType.Flat;
			else if (i % 2 == 0)
				return HouseType.House;
			else
				return HouseType.Other;
		}

		public List<HeatViewModel> GetHeatViewModelList()
		{
			List<HeatViewModel> vm = new List<HeatViewModel>();
			int recordCount = _randomSeed.Next(1, 10);

			for (int i = 0; i < recordCount; i++)
			{
				HeatViewModel vmEntity = new HeatViewModel();
				vmEntity.Name = "Heat " + i;
				vmEntity.Price = i * 10;
				vmEntity.Temperatures = GetTemperatures();
				vm.Add(vmEntity);
			}

			return vm;
		}

		private List<int> GetTemperatures()
		{
			int temperatureRecordCount = _randomSeed.Next(1, 10);

			List<int> temperatures = new List<int>();
			for (int i = 0; i < temperatureRecordCount; i++)
			{
				temperatures.Add(i);
			}

			return temperatures;
		}



	}
}
