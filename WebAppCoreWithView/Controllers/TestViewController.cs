using Microsoft.AspNetCore.Mvc;
using WebAppCoreWithView.Interface;
using WebAppCoreWithView.Models;

namespace WebAppCoreWithView.Controllers
{
    public class TestViewController : Controller
    {
        private IUser _IUser;

        public TestViewController(IUser iUser)
        {
            _IUser = iUser;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Save(User user)
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


        [HttpGet]
        public IActionResult Login()
        {
            try
            {
                List<User> users = new List<User>();

                User user = new User();
                user.FirstName = "Test";
                user.Email = "Test@email.com";
                users.Add(user);

                return View(users);
                //return (IEnumerable<User>)View(users);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
