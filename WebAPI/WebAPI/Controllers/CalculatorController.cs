using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        // api/Calculator/Add?x=45&y=98
        [HttpGet("calulator/Add")] 
        public int Add(int a,int b)
        {
            return a + b;
        }
        // api/Calculator/Add?x=95&y=9
        [HttpPost("calculator/sum")]
        public int Sum(int a, int b)
        {
            return a + b;
        }
        // api/Calculator/Add?x=95&y=9
        [HttpPut]
        public int Multiplication(int a, int b)
        {
            return a * b;
        }
        [HttpDelete]
        // api/Calculator/Add?x=65&y=13 
        public int Divide(int a, int b)
        {
            return a / b;
        }
    }
}
