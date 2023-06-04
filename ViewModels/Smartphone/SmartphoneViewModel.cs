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
		public ObservableCollection<SmartphoneListModel> SmartphonesComparisonList { get; set; } = new ObservableCollection<SmartphoneListModel>();
        public ObservableCollection<SmartphoneModel> SmartphonesComparisonListComparsionView { get; set; } = new ObservableCollection<SmartphoneModel>();
        public int totalPages { get; set; } = 0;

		public SmartphoneViewModel(INavigationService navigationService, ISmartphoneService smartphonesService) : base(navigationService)
		{
			_smartphoneService = smartphonesService;
		}
        public async Task GetSmartphones(string filter)
        {
			var smartphones = await _smartphoneService.GetSmartphonesAsync(filter);

			if(smartphones != null)
			{
				SmartphonesList = new ObservableCollection<SmartphoneListModel>(smartphones);
			}
			else
			{
				SmartphonesList = null;
			}
		}

		public async Task GetPages(string filter)
		{
			var totalPagesCount = await _smartphoneService.GetPagesAsync(filter);

			if (totalPagesCount != 0)
			{
				totalPages = totalPagesCount;
			}
			else
			{
				totalPages = 0;
			}
		}

		public async Task AddToComparison(SmartphoneListModel smartphone)
		{
			var smarphoneWithDetails = new SmartphoneModel();
			if (!SmartphonesComparisonList.Contains(smartphone))
			{
				SmartphonesComparisonList.Add(smartphone);
				smarphoneWithDetails = await _smartphoneService.GetSmartphoneByIdAsync(smartphone.id);
				SmartphonesComparisonListComparsionView.Add(smarphoneWithDetails);
			}

			if (SmartphonesComparisonList.Count > 3)
			{
				SmartphonesComparisonList.Remove(SmartphonesComparisonList.Last());
			}
		}

		public async Task RemoveFromComparison(SmartphoneListModel smartphone)
		{
			SmartphonesComparisonList.Remove(smartphone);
		}

		public Task GetSmartphoneById()
		{
			throw new NotImplementedException();
		}
	}
}
