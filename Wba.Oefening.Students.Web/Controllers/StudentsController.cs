using Microsoft.AspNetCore.Mvc;
using Wba.Oefening.Students.Core;
using Wba.Oefening.Students.Web.ViewModels;

namespace Wba.Oefening.Students.Web.Controllers
{
    public class StudentsController : Controller
    {
        private readonly StudentsRepository _studentsRepository;

        public StudentsController()
        {
            _studentsRepository = new StudentsRepository();
        }

        public IActionResult Index()
        {
            ViewData["PageTitle"] = "Welgekommen";

            return View();
        }

        
        public IActionResult Details(int id)
        {
            var students = _studentsRepository.GetStudents().FirstOrDefault(s => s.Id == id);

            var studentsDetailsViewModel = new StudentsDetailsViewModel();

            studentsDetailsViewModel.Id = students?.Id ?? 0;
            studentsDetailsViewModel.Name = students?.FirstName + " " + students?.LastName ?? "Geen Naam";
            studentsDetailsViewModel.Course = students?.Course ?? "Geen Vak";

            return View(studentsDetailsViewModel);
        }

    }
}
