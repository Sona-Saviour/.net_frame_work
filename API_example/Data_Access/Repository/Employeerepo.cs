using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data_Access.Context;
using Data_Access.Models;
using Microsoft.AspNetCore.Mvc;

namespace Data_Access.Repository
{
   

    public class Employeerepo : ControllerBase
    {
        private DataContext _context;
        private EmployeeModel _model;

        public Employeerepo(EmployeeModel model, DataContext context)
        {
            _context = context;
            _model = model;
        }

        public async Task<dynamic> GetnameRepo(string name)
        {
            var res = "My name is" + name;
            return res;
        } 

        public async Task<IActionResult> GetAllempdetailsrepo()
        {
            var cmd = "SELECT * FROM Employee";
            var employees = new List<EmployeeModel>();
            using (var connection = _context.CreateConnection()) 
            { 
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd,connection);

                using (var reader = await command.ExecuteReaderAsync()) 
                { 
                  while (await reader.ReadAsync())
                    {
                        var employee = new EmployeeModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ename = reader.GetString(reader.GetOrdinal("ename")),
                            designation = reader.GetString(reader.GetOrdinal("designation")),
                            salary = reader.GetInt32(reader.GetOrdinal("salary")),
                            dept = reader.GetString(reader.GetOrdinal("dept"))
                        };

                        employees.Add(employee);
                    }
                
                }

            }

            return Ok(employees);
        }
    }
    
}
