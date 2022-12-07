using CovidWebAPI.Contracts;
using CovidWebAPI.Entities;
using CovidWebAPI.Models;

namespace CovidWebAPI.Repositories
{
    public class RegistrationRepository : IUserContract
    {
        private readonly LoginDBContext loginDBContext;
        public RegistrationRepository()
        {
            loginDBContext = new LoginDBContext();
        }


        public void Register(User user)
        {
            try
            {
                loginDBContext.Users.Add(user);
                loginDBContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public User ValidateUser(Login user)
        {
            try
            {
                User u = loginDBContext.Users.SingleOrDefault(u => u.Email == user.Email && u.Password == user.Password);
                return u;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
