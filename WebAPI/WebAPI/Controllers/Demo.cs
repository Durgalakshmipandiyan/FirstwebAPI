using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Demo : ControllerBase
    {
        [HttpPost("demo/sum")]
        public int Sum(int a, int b)
        {
            return a + b+500;
        }
    }
}
