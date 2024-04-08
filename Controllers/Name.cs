using Microsoft.AspNetCore.Mvc;

namespace Simple_Api_Development.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class Name : Controller
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("My name is Wahaj");
        }

        [HttpPost]
        public IActionResult Post([FromBody] string statement)
        {
            return Ok(statement + "Ahmed");
        }

    
        [HttpPost("Come", Name = "Come")]
        public IActionResult Come([FromBody] string data)
        {
            string myTarget = "Wahaj";

            int index = data.IndexOf(myTarget);
            if (index != -1)
            {
                string result = data.Substring(index);
                return Ok("My substring is: " + result);    
            }
            else
            {
                return NotFound("Keyword is not present");
            }
            
        }
        [HttpPut]
        public IActionResult Put([FromBody] string data)
        {
            string myTarget = "Wahaj";

            int index = data.IndexOf(myTarget);
            if (index != -1)
            {
                string result = data.Replace(myTarget, myTarget.ToUpper(), StringComparison.OrdinalIgnoreCase);
                return Ok(result);
            }
            else
            {
                return NotFound("Keyword is not present");
            }   
        }


   
        
        

    }
}
