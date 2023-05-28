namespace GadgetBlitzPZ.Models.Smartphone
{
    public class SmartphoneListResponse
    {
        public List<SmartphoneListModel> Content { get; set; }
        public int TotalPages { get; set; }
        public int TotalElements { get; set; }
    }
}
