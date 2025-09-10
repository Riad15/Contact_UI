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



		//[Route("/Person/Create")]

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

                TempData["Success"] = "Person created successfully!";
				return RedirectToAction("Index");
			}
			// Logic to save the person would go here
			return View(person);
		
        }

		


		public IActionResult Details(int id)
        {
			var person = PersonRepository.GetAllPersons().FirstOrDefault(p => p.Id == id);
			if (person == null)
            {
				return NotFound();
			}
			return View(person);
		}


		public IActionResult Delete(int id)
		{

			var person = PersonRepository.GetAllPersons().FirstOrDefault(p => p.Id == id);
			if (person == null)
			{
				return NotFound();
			}

			
			return View(person);
		}
		[HttpPost, ActionName("Delete")]

		public IActionResult ConfirmDelete(int id)
		{
			PersonRepository.DeletePerson(id);
			TempData["Success"] = "Person deleted successfully!";
			return RedirectToAction("Index");
		}

        

    }
}
