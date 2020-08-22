using BuisnessRuleEngineController.Model;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace BuisnessRuleEngin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuisnessRuleEngineController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> GetActivePromo()
        {
            return new string[] { "value1", "value2" };
        }

        // POST api/values
        [HttpPost]
        public void Post(PaymentDetails paymentDetails)
        {
        }


    }
}
