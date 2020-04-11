using Zodiac.Models;
using Zodiac.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace Zodiac.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Result()
        {
            try
            {
                Person person = new Person(
                    HttpContext.Request.Form["Name"],
                    HttpContext.Request.Form["Surname"],
                    HttpContext.Request.Form["Email"],
                    new Dates(HttpContext.Request.Form["Date"])
                    );
                if (person.IsBirthday)
                {
                    ViewBag.Whishes = "Happy Birthday to you!";
                }
                return View(person);
            } catch (NotBirthException)
            {
                return Redirect("/Home/NotBirth");
            }
            catch (OldBirthException)
            {
                return Redirect("/Home/OldBirth");
            }
            catch (InvalidEmailException)
            {
                return Redirect("/Home/InvalidEmail");
            }
        }

        public IActionResult NotBirth()
        {
            return View();
        }

        public IActionResult OldBirth()
        {
            return View();
        }

        public IActionResult InvalidEmail()
        {
            return View();
        }


    }
}


