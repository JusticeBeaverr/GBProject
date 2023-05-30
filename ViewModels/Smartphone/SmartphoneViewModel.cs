using GadgetBlitzPZ.Models.Smartphone;
using GadgetBlitzPZ.Services.NavigationService;
using GadgetBlitzPZ.Services.Smartphone;
using GadgetBlitzPZ.ViewModels.Base;
using System.Collections.ObjectModel;

namespace GadgetBlitzPZ.ViewModels.Smartphone
{
	public class SmartphoneViewModel : BaseViewModel, ISmartphoneViewModel
	{
		private readonly ISmartphoneService _smartphoneService;
		public ObservableCollection<SmartphoneModel> Smartphones { get; set; } = new ObservableCollection<SmartphoneModel>();
		public ObservableCollection<SmartphoneListModel> SmartphonesList { get; set; } = new ObservableCollection<SmartphoneListModel>();

		public SmartphoneViewModel(INavigationService navigationService, ISmartphoneService smartphonesService) : base(navigationService)
		{
			_smartphoneService = smartphonesService;
		}
        public async Task GetSmartphones(string filter)
        {
			var smartphones = await _smartphoneService.GetSmartphonesAsync(filter);

            SmartphonesList = new ObservableCollection<SmartphoneListModel>(smartphones);
		}

        public Task GetSmartphoneById()
		{
			throw new NotImplementedException();
		}
	}
}
