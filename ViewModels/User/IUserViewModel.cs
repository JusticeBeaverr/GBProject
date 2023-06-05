using GadgetBlitzPZ.Models.User;

namespace GadgetBlitzPZ.ViewModels.User
{
    public interface IUserViewModel
    {
        UserModel newUser { get; set; }

        Task Registration();
        Task Login();
        string Username { get; set; }
    }
}
