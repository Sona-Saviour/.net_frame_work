﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;

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




        //public string getapiData(string datas)     //Get API Response
        //{
        //    // Split the input string 'datas' using '$' as the delimiter
        //    //string[] datastring = datas.Split("$");
        //    // Construct the API path using the second and first elements of the split array
        //    string ApiPath = "https://localhost:7271/" + datas;


        //    // Create an instance of HttpClient to make the HTTP request
        //    using (var client = new HttpClient())
        //    {
        //        // Initialize a variable to hold the response data
        //        string data = "";
        //        // Set the base address of the HttpClient to the constructed API path
        //        client.BaseAddress = new Uri(ApiPath);
        //        // Make a GET request to the API and wait for the result
        //        HttpResponseMessage result = client.GetAsync(client.BaseAddress).Result;
        //        // Check if the response indicates success
        //        if (result.IsSuccessStatusCode)
        //        {
        //            // Read the response content as a string
        //            data = result.Content.ReadAsStringAsync().Result;
        //        }
        //        // Return the response data 
        //        return data;
        //    }
        //}
    }
}
