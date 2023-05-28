using System.ComponentModel.DataAnnotations;

namespace GadgetBlitzPZ.Models.User
{
    public class UserModel
    {
        public Guid Id { get; set; }
        public NameModel Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

    }
}