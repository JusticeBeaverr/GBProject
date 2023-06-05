using GadgetBlitzPZ.Models.User;
using GadgetBlitzPZ.Services.NavigationService;
using GadgetBlitzPZ.ViewModels.Base;

namespace GadgetBlitzPZ.ViewModels.User
{
    public class UserViewModel : BaseViewModel, IUserViewModel
    {
        public UserViewModel(INavigationService navigationService) : base(navigationService)
        {
        }

        public UserModel newUser { get; set; } = new UserModel();
        public string Username { get; set; }

        public async Task Registration()
        {
            var test = new UserModel();

           
            test.Email = newUser.Email;
            test.Password = newUser.Password;
        }

        public async Task Login()
        {
            var test = new UserModel();
            Username = newUser.Email;
            test.Password = newUser.Password;
        }
    }
}
