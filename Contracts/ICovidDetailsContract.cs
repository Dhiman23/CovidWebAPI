using CovidWebAPI.Entities;
namespace CovidWebAPI.Contracts
{
    public interface ICovidDetailsContract
    {
        List<CovidDetails> GetCovidDetails();
        CovidDetails GetCovidDetail(string CountryName);
        void AddCovidDetails(CovidDetails covidDetails);
       

    }
}
