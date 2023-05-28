using GadgetBlitzPZ.Models.Smartphone;
using System.Collections.ObjectModel;

namespace GadgetBlitzPZ.ViewModels.Smartphone
{
    public interface ISmartphoneViewModel
    {
        ObservableCollection<SmartphoneModel> Smartphones { get; set; }
        ObservableCollection<SmartphoneListModel> SmartphonesList { get; set; }
		Task GetSmartphones();
        Task GetSmartphoneById();
    }
}
