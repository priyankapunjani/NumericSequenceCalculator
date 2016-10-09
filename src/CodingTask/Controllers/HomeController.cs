using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//..
using CodingTask.Models;
using CodingTask.Services;
using CodingTask.ViewModels;

namespace CodingTask.Controllers
{
     
    public class HomeController : Controller
    {
        //private field
        private IcalculatorService _service;
        //constructor
        public HomeController(IcalculatorService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            //need a new object of IndexViewModel
            IndexViewModel vm = new IndexViewModel();
            //and a new object of List<MyNumberModel> 
            List<MyNumberModel> mydata = new List<MyNumberModel>();

            vm.Number = new MyNumberModel {Num=0};
            vm.AllNumbers = mydata;
            vm.EvenNumbers = mydata;
            vm.OddNumbers = mydata;
            vm.FiboNumbers = mydata;
            return View(vm);          
        }

        [HttpPost]
        public IActionResult Index(IndexViewModel vm)
        {
            //calling GetAll() through the service
            vm.AllNumbers = _service.GetAll(vm.Number.Num);

            //calling GetEven() through the service
            vm.EvenNumbers = _service.GetEven(vm.Number.Num);

            //calling GetOdd() through the service
            vm.OddNumbers = _service.GetOdd(vm.Number.Num);

            //calling GetFibo() through the service
            vm.FiboNumbers = _service.GetFibo(vm.Number.Num);

            vm.Message = _service.Message(vm.Number.Num);
            return View(vm);
        }
    }
}
