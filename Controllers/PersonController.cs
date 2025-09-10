using Contact_UI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Contact_UI.Controllers
{
    public class PersonController : Controller
    {

        [Route("/Person")]
        public IActionResult Index()
           
        {
            var person = PersonRepository.GetAllPersons();

            return View(person);
        }



        [Route("/Person/Create")]
   
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Person person)
        {

            if (ModelState.IsValid)
            {
                PersonRepository.AddPerson(person);
				return RedirectToAction("Index");
			}
			// Logic to save the person would go here
			return View(person);
		
        }
    }
}
