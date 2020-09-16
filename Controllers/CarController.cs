using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VehicleManagementSystem.Web.DataContext;
using VehicleManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Security.Cryptography.X509Certificates;

namespace VehicleManagementSystem.Web.Controllers
{
    public class CarController : Controller
    {
        private VehiclesDBContext _context;

        public CarController(VehiclesDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cars = _context.Cars.ToList();
            return View(cars);
            

        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Car ObjCar)
        {
            try
            {
                //Determine the next ID
                var newID = _context.Cars.Select(x => x.ID).Max() + 1;
                
                ObjCar.ID = newID;

                _context.Cars.Add(ObjCar);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch(Exception Ex)
            {
                TempData["notice"] = "Error";
                return RedirectToAction("Add", "Car");
                
            }
           

        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _context.Cars.Remove(_context.Cars.Find(id));
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            
            var ObjCar = _context.Cars.Find(id);

            return View(ObjCar);
            
        }

        [HttpPost]
        public IActionResult Edit(Car ObjCar)
        {
            
                 
                _context.Cars.Update(ObjCar);
                _context.SaveChanges();

                return RedirectToAction("Index");
            
            
        }

       

        
    }
}