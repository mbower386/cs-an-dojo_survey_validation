using DojoSurveyValidation.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Diagnostics;

namespace DojoSurveyValidation.Controllers
{
    public class DojoSurveyValidationController : Controller
    {
        // Index
        [HttpGet ("")]
        public IActionResult Index ()
        {
            return View (new Survey ());
        }

        // remember to use [HttpPost] attributes!
        [HttpPost ("survey/create")]
        public IActionResult Submit (Survey survey)
        {
            if (ModelState.IsValid)
            {
                return View ("Survey", survey);
            }
            else
            {
                return View ("Index");
            }
        }

    }
}