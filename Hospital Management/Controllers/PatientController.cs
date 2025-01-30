using Hospital_Management.Data;
using Hospital_Management.Models;
using Hospital_Management.Repository.Implementation;
using Hospital_Management.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Hospital_Management.Controllers
{
    public class PatientController : Controller
    { 
        /*        private readonly IPaitientRepository _patientRepository;
                public PatientController(IPaitientRepository patientRepository)
                {
                    _patientRepository = patientRepository;
                }

                public IActionResult Index()
                {
                    List<Patient> obj2PatientList = _patientRepository.GetAll().ToList();
                    return View(obj2PatientList);
                }*/
        private readonly ApplicationDbContext _db2;
        public PatientController(ApplicationDbContext db)
        {
            _db2 = db;
        }

        //Retrive
        public IActionResult Index()
        {
            List<Patient> obj2PatientList = _db2.Patients.ToList();
            return View(obj2PatientList);
        }

    
        [HttpGet]
        public IActionResult Create()
        {
         
            return View();
        }
        [HttpPost]
        public IActionResult Create(Patient obj2)
        {
            _db2.Add(obj2);
            _db2.SaveChanges();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Patient patientFromDb = _db2.Patients.FirstOrDefault(u => u.PatientID == id);
            if (patientFromDb == null)
            {
                return NotFound();
            }
            return View(patientFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Patient obj2)
        {
            if (ModelState.IsValid)
            {
                _db2.Update(obj2);
                _db2.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(obj2);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Patient patientFromDb = _db2.Patients.FirstOrDefault(u => u.PatientID == id);
            if (patientFromDb == null)
            {
                return NotFound();
            }
            return View(patientFromDb);
        }

        public IActionResult DeletePOST(int? id)
        {
            Patient? patientFromDb = _db2.Patients.FirstOrDefault(u => u.PatientID == id);
            if (patientFromDb == null)
            {
                return NotFound();
            }
            _db2.Remove(patientFromDb);
            _db2.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
