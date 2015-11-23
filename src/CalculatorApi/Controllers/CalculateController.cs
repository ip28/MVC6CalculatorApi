using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace CalculatorApi.Controllers
{
    [Route("api/[controller]")]
    public class CalculateController : Controller
    {
        [HttpGet("Add")]
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}
