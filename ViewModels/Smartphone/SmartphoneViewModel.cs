using GadgetBlitzPZ.Models.Smartphone;
using System.Collections.ObjectModel;

namespace GadgetBlitzPZ.ViewModels.Smartphone
{
    public class SmartphoneViewModel : ISmartphoneViewModel
    {
        private ObservableCollection<SmartphoneModel> _smartphones;

        public ObservableCollection<SmartphoneModel> Smartphones => _smartphones;

        public void LoadSmartphones()
        {
            // Wczytywanie z bazy
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
