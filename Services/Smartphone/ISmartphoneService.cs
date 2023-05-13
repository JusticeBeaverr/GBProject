using GadgetBlitzPZ.Models.Smartphone;

namespace GadgetBlitzPZ.Services.Smartphone
{
    public interface ISmartphoneService
    {
        Task<List<SmartphoneModel>> GetSmartphonesAsync();
        Task<SmartphoneModel> GetSmartphoneByIdAsync(string id);
    }
}
