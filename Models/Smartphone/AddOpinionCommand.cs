namespace GadgetBlitzPZ.Models.Smartphone
{
    public class AddOpinionCommand
    {
        public string SmartphoneId { get; set; }
        public OpinionModel Opinion { get; set; }
    }
}
