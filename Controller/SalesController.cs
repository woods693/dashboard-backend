using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using DataApi.Models;

namespace DataApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        [HttpGet("data1")]
        public IActionResult GetData1()
        {
          return GetSalesData("data1.json");
        }

        [HttpGet("data2")]
        public IActionResult GetData2()
        {
          return GetSalesData("data2.json");
        }

        [HttpGet("data3")]
        public IActionResult GetData3()
        {
          return GetSalesData("data3.json");
        }

        [HttpGet]
        public IActionResult GetSalesData(string fileName)
        {
            var jsonFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Data", fileName);

            if (!System.IO.File.Exists(jsonFilePath))
            {
                return NotFound($"Data file {fileName} not found.");
            }
            var jsonData = System.IO.File.ReadAllText(jsonFilePath);
            var dailyData = JsonConvert.DeserializeObject<Dictionary<string, List<Sale>>>(jsonData);
            return Ok(dailyData);
        }
    }
}
