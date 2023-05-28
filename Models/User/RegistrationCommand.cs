namespace GadgetBlitzPZ.Models.User
{
    public class RegistrationCommand
    {
        public NameModel Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
