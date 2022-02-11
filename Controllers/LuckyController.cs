using Microsoft.AspNetCore.Mvc;

namespace ResponseService.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class LuckyController : ControllerBase
    {
        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(int id)
        {
            System.Console.WriteLine("Invoking Lucky");
            var randomIntGenerator = new Random();
            var randomInt = randomIntGenerator.Next(100);
            System.Console.WriteLine($"The random int is {randomInt}");
            if (id > randomInt)
            {
                return Ok($"The int you passed is {id} and the random int was {randomInt}");
            }
            return StatusCode(StatusCodes.Status500InternalServerError);
        }
    }
}