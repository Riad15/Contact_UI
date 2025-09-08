using Contact_UI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Contact_UI.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
           
        {
            var person = PersonRepository.GetAllPersons();

            return View(person);
        }


        public IActionResult ContactList()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(object person)
        {
            // Logic to save the person would go here
            return RedirectToAction("ContactList");
        }
    }
}
