using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Business.services
{
    public class Employeeservices
    {
        private readonly Employeerepo _repo;

        public Employeeservices(Employeerepo repo)
        {
            _repo = repo;
        }



        public async Task<dynamic> GetnameService(string name)
        {
            var res=await _repo.GetnameRepo(name);
            return res;
        }

        public async Task<IActionResult> GetallempdetailsService()
        {
            var res = await _repo.GetAllempdetailsrepo();
            return res;
        }
    }
  
}
