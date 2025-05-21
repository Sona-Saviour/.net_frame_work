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




        [HttpGet("SearchById/{id}", Name = "SearchById")]

        public async Task<IActionResult> SearchById([FromRoute] int id)
        {
            var cmd = "SELECT * FROM Employee WHERE Id=@id";
            var employees = new List<EmployeeModel>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);

                command.Parameters.AddWithValue("@id", id);

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


        // post employees

        [HttpPost("InsertEmployee", Name="InsertEmployee")]

        public async Task<IActionResult> InsertEmployee([FromBody] EmployeeModel employee)
        {
            if(employee == null || string.IsNullOrWhiteSpace(employee.ename))
            {
                return BadRequest("Invalid employee data.");
            }

            var cmd = "INSERT INTO Employee(Id,ename,designation,salary,dept) VALUES (@id,@ename,@designation,@salary,@dept)";


            using (var connection = _context.CreateConnection())


            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd,connection);

                //Add the parameters to the command
                command.Parameters.AddWithValue("@id",employee.Id);
                command.Parameters.AddWithValue("@ename", employee.ename);
                command.Parameters.AddWithValue("@designation", employee.designation);
                command.Parameters.AddWithValue("@salary", employee.salary);
                command.Parameters.AddWithValue("@dept", employee.dept);


                int rowsAffected = await command.ExecuteNonQueryAsync();

                if (rowsAffected > 0)
                {
                    return Ok(employee.Id);
                }
                else 
                {

                    return BadRequest("Failed to insert employee.");
                }



            }
        }




        public IActionResult Index()
        {
            return View();
        }
    }

}