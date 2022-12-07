using CovidWebAPI.Entities;
using CovidWebAPI.Models;

namespace CovidWebAPI.Contracts
{
    public interface IUserContract
    {
        public void Register(User user);
        User ValidateUser(Login user);

   
    }
}
