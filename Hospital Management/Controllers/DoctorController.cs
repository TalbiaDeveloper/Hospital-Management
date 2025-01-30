using System.Diagnostics;
using Hospital_Management.Data;
using Hospital_Management.Models;
using Hospital_Management.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace Hospital_Management.Controllers
{
    public class DoctorController : Controller
    {
        private readonly IDoctorRepository _doctorRepository;
        public DoctorController(IDoctorRepository doctorRepository)
        {
            _doctorRepository = doctorRepository;
        }

        public IActionResult Index()
        {
            List<Doctor> obj1DoctorList = _doctorRepository.GetAll().ToList();
            return View(obj1DoctorList);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Doctor obj1)
        {
            _doctorRepository.Add(obj1);
            _doctorRepository.Save();
            return RedirectToAction("Index");

        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Doctor doctorFromDb = _doctorRepository.Get(u => u.DoctorID == id);
            if (doctorFromDb == null)
            {
                return NotFound();
            }
            return View(doctorFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Doctor obj1)
        {
            if (ModelState.IsValid)
            {
                _doctorRepository.Update(obj1);
                _doctorRepository.Save();
                return RedirectToAction("Index");
            }
            return View(obj1);
        }

        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            Doctor doctorFromDb = _doctorRepository.Get(u => u.DoctorID == id);
            if (doctorFromDb == null)
            {
                return NotFound();
            }
            return View(doctorFromDb);
        }

        public IActionResult DeletePOST(int? id)
        {
            Doctor? doctorFromDb = _doctorRepository.Get(u => u.DoctorID == id);
            if (doctorFromDb == null)
            {
                return NotFound();
            }
            _doctorRepository.Remove(doctorFromDb);
            _doctorRepository.Save();
            return RedirectToAction("Index");
        }
    }
}

