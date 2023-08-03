using Microsoft.AspNetCore.Mvc;
using Caminhos.Global;
using System.Runtime.CompilerServices;
using System.Diagnostics.CodeAnalysis;

namespace Caminhos.Controllers
{
    [ApiController]
    [Route("api/home")]
    public class HomeController : Controller
    {
        [NonAction]
        public string HandShake()
        {
            return "ok";
        }

        [HttpGet]
        [Route("TestLog")]
        public string TestLog(string message)
        {
            Log.Save(message);
            return "Log salvo";
        }
        [HttpGet]
        [Route("CalcularMedia")]
        public JsonResult CalcularMedia(float n1,float n2)
        {
            return new JsonResult(new { resultado = Calcular( n1, n2) });
        }
        private float Calcular(float n1,float n2)
        {
            return (n1 + n2) / 2;
        }
    }
}
