using System.Text;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using mvc_example1.Models;
using Newtonsoft.Json;

namespace mvc_example1.Controllers
{
    public class EmployeeController : Controller
    {
       

        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult EmployeeReport()
        {
            return View();
        }

        public IActionResult SearchEmployee()
        {
            return View();
        }
        

        public IActionResult SearchById()
        {
            return View();
        }

        public IActionResult InsertEmployee()
        {
            return View();
        }

        public IActionResult ViewReport_Model()
        {
            return View();
        }

        public IActionResult BranchSearch_Model()
        {
            return View();
        }


        public IActionResult InsertEmployee_Model()
        {
            return View();
        }


        public string getAPIData(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7271/" + datas;
            

            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data
                string data = "";
                // Set the base address of the HttpClient to the constructed API path
                client.BaseAddress = new Uri(ApiPath);
                // Make a GET request to the API and wait for the result
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                // Check if the response indicates success
                if (result.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    data = result.Content.ReadAsStringAsync().Result;
                }
                // Return the response data 
                return data;
            }
        }


        public async Task<dynamic> postAPIData(string datas)
        {
            string[] datastring1 = datas.Split("$");

            string ApiPath = "https://localhost:7271/" + datastring1[0];

            var data = "";

            string[]  datastring2 = datastring1[1].Split("~");

            using (HttpClient client = new HttpClient())
            {
                string content = JsonConvert.SerializeObject(new
                {
                    id=datastring2[0],
                    ename = datastring2[1],
                    designation = datastring2[2],
                    salary = datastring2[3],
                    dept = datastring2[4]                
                });

                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new
                    System.Net.Http.Headers.MediaTypeHeaderValue
                    ("application/json");


                HttpResponseMessage result = await client.PostAsync(ApiPath, byteContent);

                if (result.IsSuccessStatusCode)
                { 
                    data = result.Content.ReadAsStringAsync().Result;

                }

            }

            return data;

        }




        public List<EmployeeModel> getAPIData_model(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7271/" + datas;


            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data
                List<EmployeeModel> employees = new List<EmployeeModel>();
                // Set the base address of the HttpClient to the constructed API path
                client.BaseAddress = new Uri(ApiPath);
                // Make a GET request to the API and wait for the result
                HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
                // Check if the response indicates success
                if (result.IsSuccessStatusCode)
                {
                    // Read the response content as a string
                    var jsonData = result.Content.ReadAsStringAsync().Result;
                    var apiResponse = JsonConvert.DeserializeObject<List<dynamic>>(jsonData);

                    foreach (var item in apiResponse)
                    {
                        var employee = new EmployeeModel
                        {
                            Id = item.id,
                            Ename = item.ename,
                            Designation = item.designation,
                            Salary = item.salary,
                            Department = item.dept
                        };

                        employees.Add(employee);
                    }

                }
                // Return the response data 
                return employees;
            }
        }



        public async Task<IActionResult> postAPIData_model([FromBody] EmployeeModel employee)
        {


            string ApiPath = "https://localhost:7271/InsertEmployee";

            var apiData = new
            {
                id = employee.Id,
                ename = employee.Ename,
                designation = employee.Designation,
                salary = employee.Salary,
                dept = employee.Department,


            };

           var data = "";
            using (HttpClient client = new HttpClient())
            {
                string content = JsonConvert.SerializeObject(apiData);
               
                var buffer = Encoding.UTF8.GetBytes(content);
                var byteContent = new ByteArrayContent(buffer);
                byteContent.Headers.ContentType = new
                    System.Net.Http.Headers.MediaTypeHeaderValue
                    ("application/json");

                HttpResponseMessage result = await client.PostAsync(ApiPath, byteContent);

                if (result.IsSuccessStatusCode)
                {
                    data =  result.Content.ReadAsStringAsync().Result;
                    return Ok(data);

                }

                else
                {
                    return StatusCode((int)result.StatusCode, "Error occured while inserting employee.");
                }

            }

           

        }





    }
}
