using Microsoft.AspNetCore.Mvc;
using WebAppCoreWithView.Interface;
using WebAppCoreWithView.Models;

namespace WebAppCoreWithView.Controllers
{
    public class TestUserController : Controller
    {
        private readonly IUser _IUser;
        

        public TestUserController(IUser iUser)
        {
            _IUser = iUser;
        }

        [HttpPost]
        public IActionResult Save([FromBody] User user)
        {
            try
            {
                _IUser.SaveUser(user);

                return base.Json("Save");
            }
            catch (Exception)
            {

                throw;
            }
        }

        [HttpPost]
        public IActionResult Update([FromBody] User user)
        {
            try
            {
                _IUser.UpdateUser(user);

                return base.Json("Update");
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
