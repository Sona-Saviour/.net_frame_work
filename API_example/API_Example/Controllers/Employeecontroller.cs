using Business.services;
using Data_Access.Repository;
using Microsoft.AspNetCore.Mvc;

namespace API_Example.Controllers
{
    public class Employeecontroller : Controller
    {
        private readonly Employeerepo _repo;
        private readonly Employeeservices _service;

        public Employeecontroller(Employeeservices service, Employeerepo repo)
        {
            _service = service;
            _repo = repo;
        }


        // my name is name

        [HttpGet("Getname/{name}", Name = "Getname")]

        public async Task<dynamic> Getname([FromRoute] string name)
        {
            var res = await _service.GetnameService(name);
            return res;
        }


        [HttpGet("Getallempdetails",Name = "Getallempdetails")]

        public async Task<IActionResult> Getallempdetails()
        {
            var res = await _service.GetallempdetailsService();
            return res;
        }


        public IActionResult Index()
        {
            return View();
        }
    }
}
