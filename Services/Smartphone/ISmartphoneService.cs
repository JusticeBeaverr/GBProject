using GadgetBlitzPZ.Models.Smartphone;

namespace GadgetBlitzPZ.Services.Smartphone
{
    public interface ISmartphoneService
    {
        Task<List<SmartphoneListModel>> GetSmartphonesAsync(string filter);
        Task<int> GetPagesAsync(string filter);
        Task<SmartphoneModel> GetSmartphoneByIdAsync(string id);
        Task AddOpinion(AddOpinionCommand command);
	}
}
