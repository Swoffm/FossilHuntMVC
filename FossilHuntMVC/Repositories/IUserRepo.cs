

using FossilHuntMVC.Models;

namespace TabloidMVC.Repositories
{
    public interface IUserProfileRepository
    {
        User GetByEmail(string email, string username);
    }
}