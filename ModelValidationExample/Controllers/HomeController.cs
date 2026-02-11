using Microsoft.AspNetCore.Mvc;
using ModelValidationExample.CustomModelBinders;
using ModelValidationExample.Models;

namespace ModelValidationExample.Controllers
{
    public class HomeController : Controller
    {
        [Route("register")]
        public IActionResult Index([ModelBinder
            (binderType:typeof(PersonModelBinder))]Person person)
        {
            if (!ModelState.IsValid) {
                List<string> errors = ModelState.Values.SelectMany(value =>
                value.Errors).Select(err => err.ErrorMessage).ToList();

                return BadRequest(errors);
            }
            return Content($"{person}");
        }
    }
}
