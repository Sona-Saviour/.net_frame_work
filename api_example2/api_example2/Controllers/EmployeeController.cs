using api_example2.context;
using api_example2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace api_example2.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeModel _model;
        private DataContext _context;

        public EmployeeController(EmployeeModel model, DataContext context)
        {
            _model = model;
            _context = context;
        }

        [HttpGet("Getallempdetails", Name = "Getallempdetails")]

        public async Task<IActionResult> GetAllempdetails()
        {
            var cmd = "SELECT * FROM Employee";
            var employees = new List<EmployeeModel>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);

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




        [HttpGet("Getnamedetails", Name = "Getnamedetails")]

        public async Task<IActionResult> Getnamedetails()
        {
            var cmd = "SELECT Id,ename FROM Employee";
            var employees = new List<EmployeeModel>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var employee = new EmployeeModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            ename = reader.GetString(reader.GetOrdinal("ename")),
                            //designation = reader.GetString(reader.GetOrdinal("designation")),
                            //salary = reader.GetInt32(reader.GetOrdinal("salary")),
                            //dept = reader.GetString(reader.GetOrdinal("dept"))
                        };

                        employees.Add(employee);
                    }

                }

            }

            return Ok(employees);
        }


        public IActionResult Index()
        {
            return View();
        }
    }

}