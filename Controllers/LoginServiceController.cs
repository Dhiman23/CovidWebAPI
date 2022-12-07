using CovidWebAPI.Entities;
using CovidWebAPI.Models;
using CovidWebAPI.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CovidWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginServiceController : ControllerBase
    {
        private readonly RegistrationRepository registrationRepository;

        public LoginServiceController()
        {
            registrationRepository = new RegistrationRepository();
        }


        [HttpPost,Route("Register")]

        public IActionResult RegisterUser(User user)
        {
            try
            {
                registrationRepository.Register(user);
              
                return StatusCode(200, "Registered");
            }
            catch (Exception e)
            {

                return StatusCode(504, e.Message); 
            }
        }

        [HttpPost,Route("Login Validation")]

        public IActionResult LoginUser(Login login)
        {
            try
            {
             User u =   registrationRepository.ValidateUser(login);
                if (u != null)
                    return StatusCode(200, u);
                else
                    return StatusCode(300, "Error Occured");
            }
            catch (Exception e)
            {

              return StatusCode(404,e.Message);
            }
        }




    }
}
