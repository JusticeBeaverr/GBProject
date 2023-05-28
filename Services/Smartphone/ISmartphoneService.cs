using GadgetBlitzPZ.Models.Smartphone;

namespace GadgetBlitzPZ.Services.Smartphone
{
    public interface ISmartphoneService
    {
        Task<List<SmartphoneListModel>> GetSmartphonesAsync(string filter);
        Task<SmartphoneModel> GetSmartphoneByIdAsync(string id);
    }
}
