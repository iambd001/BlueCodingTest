using BlueCodingTest.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using model=BlueCodingTest.Models;
namespace BlueCodingTest.Controllers
{
    public class BirdsController : Controller
    {
        public IBirds _service { get; set; }
        public BirdsController(IBirds service) 
        {
            _service = service;
        }
        public IActionResult Index()
        {
            List<model.Birds> list = new List<model.Birds>();
            list = _service.getList();
            return View(list);
        }
        public IActionResult GetSpecificBird(int id)
        {
            List<model.Birds> list = new List<model.Birds>();
            list = _service.getList().Where(x=>x.Id==id).ToList();
            return View(list);
        }
    }
}
