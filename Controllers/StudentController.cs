using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NtandoMabuthoStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult StudentDisplay()
        {
            List<Models.Student> students = new List<Models.Student>();
            {
                students.Add(new Models.Student { StudentNumber = 01234567, FirstNaam = "Jane", Surname = "Doe", Email = "jane.doe@tuks.co.za" });
                students.Add(new Models.Student { StudentNumber = 12345678, FirstNaam = "John", Surname = "Doe", Email = "john.doe@tuks.co.za" });
                students.Add(new Models.Student { StudentNumber = 23717662, FirstNaam = "Leo", Surname = "Mchunu", Email = "mchunuleo@tuks.co.za" });
                students.Add(new Models.Student { StudentNumber = 29695682, FirstNaam = "Cosmo", Surname = "Logical", Email = "cosmology@gmail.com" });
                students.Add(new Models.Student { StudentNumber = 28779832, FirstNaam = "Kenneth", Surname = "Ngubane", Email = "kenniengubane@gmail.com" });


                return View(students);
            }
        }
    }
}