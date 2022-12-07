using System.Runtime.InteropServices;
using CovidWebAPI.Entities;
using CovidWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidDetailsController : ControllerBase
    {
        private readonly CovidDetailsRepository covidDetailsRepository;
        public CovidDetailsController()
        {
            covidDetailsRepository = new CovidDetailsRepository();
        }

        [HttpGet,Route("GetCovidDetails")]

        public IActionResult GetAll()
        {
            try
            {
                List<CovidDetails> covidDetails = covidDetailsRepository.GetCovidDetails();
                return StatusCode(200, covidDetails);
            }
            catch (Exception e)
            {

               return StatusCode(500, e.Message);   
            }
        }

        [HttpGet,Route("GetCovidDeatilsById/{CountryName}")]
        public IActionResult Get(string CountryName)
        {
            try
            {
                CovidDetails covidDetails = covidDetailsRepository.GetCovidDetail(CountryName);
                if (covidDetails != null)
                    return StatusCode(200, covidDetails);
                else
                    return StatusCode(404, "Invalid id");
            }
            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }

       
         [HttpPost, Route("AddDetails")] 
        
        public IActionResult AddCovidDetails(CovidDetails covidDetails)
        {
            try
            {
                  covidDetailsRepository.AddCovidDetails(covidDetails);
                return StatusCode(200, "Covid Details Added");

            }

            catch (Exception e)
            {

                return StatusCode(500, e.Message);
            }
        }







    }
}
