using GadgetBlitzPZ.Models.Smartphone;
using System.Collections.ObjectModel;

namespace GadgetBlitzPZ.ViewModels.Smartphone
{
	public interface ISmartphoneViewModel
	{
		ObservableCollection<SmartphoneModel> Smartphones { get; set; }
		ObservableCollection<SmartphoneListModel> SmartphonesList { get; set; }

		ObservableCollection<SmartphoneListModel> SmartphonesComparisonList { get; set; }
		int totalPages { get; set; }
		Task GetSmartphones(string filter);
		Task GetPages(string filter);
		Task AddToComparison(SmartphoneListModel smartphone);
		Task RemoveFromComparison(SmartphoneListModel smartphone);
		Task GetSmartphoneById();

	}
}
