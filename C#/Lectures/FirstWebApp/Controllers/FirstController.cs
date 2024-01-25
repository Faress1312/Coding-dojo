using Microsoft.AspNetCore.Mvc; 

namespace FirstWebApp.Controllers;

    public class FirstController : Controller
    {
        // Routes
        /*
        1-url ('/' , '/users/1')
        2-method (get , post)
        3-associated function
        */

        //!Method
        [HttpGet]
        [Route("home")]
        public string Home()
         {
            return "Hello from  homz*a" ;
        }
        [HttpGet]
        [Route("first")]
        public string FirstRoute()
        {
            return "Hello from first route";
        }

        [HttpGet("params/{username}/{age}")]
        public string Params(string username, int age)
        {
            return $"Hello {username} you are {age} years old";
        }
        [HttpGet("params/{username}/{age}")]

    }
