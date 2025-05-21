using Branch_api.Context;
using Branch_api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;


namespace Branch_api.Controllers
{
    public class BranchController : Controller
    {
        private BranchModel _model;
        private DataContext _context;

        public BranchController(BranchModel model, DataContext context)
        {
            _model = model;
            _context = context;
        }


        [HttpGet("GetBranchdetails", Name = "GetBranchdetails")]

        public async Task<IActionResult> GetBranchdetails()
        {
            var cmd = "SELECT * FROM branch";
            var branches = new List<BranchModel>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var branch = new BranchModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            bname = reader.GetString(reader.GetOrdinal("bname")),
                            bhead = reader.GetString(reader.GetOrdinal("bhead")),
                            nemp = reader.GetInt32(reader.GetOrdinal("nemp")),
                           
                        };

                        branches.Add(branch);
                    }

                }

            }

            return Ok(branches);
        }




        [HttpGet("BranchSearch", Name = "BranchSearch")]

        public async Task<IActionResult> BranchSearch()
        {
            var cmd = "SELECT Id,bname FROM branch";
            var branches = new List<BranchModel>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var branch = new BranchModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            bname = reader.GetString(reader.GetOrdinal("bname")),
                            //designation = reader.GetString(reader.GetOrdinal("designation")),
                            //salary = reader.GetInt32(reader.GetOrdinal("salary")),
                            //dept = reader.GetString(reader.GetOrdinal("dept"))
                        };

                        branches.Add(branch);
                    }

                }

            }

            return Ok(branches);
        }


        [HttpGet("SearchById/{id}", Name = "SearchById")]

        public async Task<IActionResult> SearchById([FromRoute] int id)
        {
            var cmd = "SELECT * FROM branch WHERE Id=@id";
            var branches = new List<BranchModel>();
            using (var connection = _context.CreateConnection())
            {
                await connection.OpenAsync();
                using var command = new SqlCommand(cmd, connection);

                command.Parameters.AddWithValue("@id", id);

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var branch = new BranchModel
                        {
                            Id = reader.GetInt32(reader.GetOrdinal("Id")),
                            bname = reader.GetString(reader.GetOrdinal("bname")),
                            bhead = reader.GetString(reader.GetOrdinal("bhead")),
                            nemp = reader.GetInt32(reader.GetOrdinal("nemp")),
                           
                        };

                        branches.Add(branch);
                    }

                }

            }

            return Ok(branches);
        }


    }
}
