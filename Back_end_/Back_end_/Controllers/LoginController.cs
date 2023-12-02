using Microsoft.AspNetCore.Mvc;
using Back_end_.Models;

namespace Back_end_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private DocumentDbContext _documentDbContext;
        public LoginController(DocumentDbContext documentDbContext)
        {
            _documentDbContext = documentDbContext;
        }

        [HttpPost]
        [Route("login")]
        public int Login(LoginRequest loginRequest)
        {
            if (IsUserAvailable(loginRequest.Email, loginRequest.Password) == true)
            {
                return 1;
            }
            return 0;
        }

        private bool IsUserAvailable(string username, string password)
        {
            var checkUser = _documentDbContext.Users.Where(x => x.Email == username && x.Password == password).FirstOrDefault();
            if (checkUser != null)
            {
                return true;
            }
            return false;
        }
    }
}
