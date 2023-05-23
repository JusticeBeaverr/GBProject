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

        public SmartphoneViewModel(INavigationService navigationService, ISmartphoneService smartphonesService) : base(navigationService)
        {
            _smartphoneService = smartphonesService;
            GetSmartphones();
        }
        public async Task GetSmartphones()
        {
            var smartphones = await _smartphoneService.GetSmartphonesAsync();
            foreach (var smartphone in smartphones)
            {
                Smartphones.Add(smartphone);
            }
        }

        public void AddSmartphone(SmartphoneModel smartphone)
        {
            // Dodawanie nowego smartfona
        }

        public void UpdateSmartphone(SmartphoneModel smartphone)
        {
            // Update info o smartfonie
        }

        public void DeleteSmartphone(int id)
        {
            // Usuwanie smartfona
        }
    }
}
