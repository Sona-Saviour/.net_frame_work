using Branch_mvc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Branch_mvc.Controllers
{
    public class BranchController : Controller
    {

        public IActionResult Homepage()
        {
            return View();
        }

        public IActionResult BranchReport()
        {
            return View();
        }

        public IActionResult BranchSearch()
        {
            return View();
        }


        public IActionResult ViewBranch_Model()
        {
            return View();
        }

        public IActionResult BranchSearch_Model()
        {
            return View();
        }



        //public IActionResult SearchById()
        //{
        //    return View();
        //}

        public string getAPIData(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7032/" + datas;


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


        public List<BranchModel> getAPIData_model(string datas)     //Get API Response
        {
            // Split the input string 'datas' using '$' as the delimiter
            //string[] datastring = datas.Split("$");
            // Construct the API path using the second and first elements of the split array
            string ApiPath = "https://localhost:7032/" + datas;


            // Create an instance of HttpClient to make the HTTP request
            using (var client = new HttpClient())
            {
                // Initialize a variable to hold the response data
                List<BranchModel> branches = new List<BranchModel>();
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
                        var branch = new BranchModel
                        {
                            Id = item.id,
                            Bname = item.bname,
                            Bhead = item.bhead,
                            Number = item.nemp,
                           
                        };

                        branches.Add(branch);
                    }

                }
                // Return the response data 
                return branches;
            }
        }

    }
}
