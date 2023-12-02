using Back_end_.Models;
using Microsoft.AspNetCore.Mvc;

namespace Back_end_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly DocumentDbContext _documentDbContext;

        public UserController(DocumentDbContext documentDbContext)
        {
            _documentDbContext = documentDbContext;
        }



        [HttpPost]
        [Route("AddUser")]
        public async Task<Users> AddUser(Users objuser)
        {
            if (objuser.Password == objuser.Confirmpassword)
            {
                _documentDbContext.Users.Add(objuser);
                await _documentDbContext.SaveChangesAsync();
                return objuser;

            }
            return null;

        }
    }
}
