using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace GlobalizationAndLocalization.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguageController : ControllerBase
    {
        private readonly IStringLocalizer<LanguageController> _Localizer;
        public LanguageController(IStringLocalizer<LanguageController> localizer) { 
            _Localizer = localizer;
        }
        
        [HttpGet("/api/welcome")]
        public IActionResult Index() {
            return Ok(_Localizer["Welcome"].Value);
        }

    }
}
