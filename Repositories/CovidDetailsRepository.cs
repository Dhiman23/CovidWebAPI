using CovidWebAPI.Contracts;
using CovidWebAPI.Entities;

namespace CovidWebAPI.Repositories
{


    public class CovidDetailsRepository : ICovidDetailsContract
    {

        private LoginDBContext logindbContext;

        public CovidDetailsRepository()
        {
            logindbContext = new LoginDBContext();
        }

        public void AddCovidDetails(CovidDetails covidDetails)
        {
            try
            {
                logindbContext.Add(covidDetails);
                logindbContext.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public CovidDetails GetCovidDetail(string Countryname)
        {
            try
            {
                
              CovidDetails details = logindbContext.Covid.SingleOrDefault(x => x.CountryName ==Countryname);
                return details;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<CovidDetails> GetCovidDetails()
        {
            try
            {
                return logindbContext.Covid.ToList();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
