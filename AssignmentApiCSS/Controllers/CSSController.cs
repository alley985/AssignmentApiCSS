using myBookAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace myBookAPI.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class CSSController : ControllerBase
    {
        public CSSServices _Services { get; set; }
        public CSSController(CSSServices cSSServices)
        {
            _Services = cSSServices;
        }
        [HttpGet]
        public string Get()
        {
            return _Services.getCss();
        }
    }
}
