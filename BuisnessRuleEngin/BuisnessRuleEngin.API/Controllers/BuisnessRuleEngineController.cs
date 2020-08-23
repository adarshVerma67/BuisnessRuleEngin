using BuisnessRuleEngine.Service;
using BuisnessRuleEngineControllers.Model;
using Microsoft.AspNetCore.Mvc;
using System;

namespace BuisnessRuleEngin.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuisnessRuleEngineController : ControllerBase
    {
        private readonly IBuisnessRuleEngineService buisnessRuleEngineService;
        public BuisnessRuleEngineController(IBuisnessRuleEngineService _buisnessRuleEngineService)
        {
            buisnessRuleEngineService = _buisnessRuleEngineService;
        }

        /// <summary>
        /// Gets All Payments
        /// </summary>
        /// <returns>List of Payments</returns>
        [HttpGet("GetAllPayments")]
        public ActionResult GetAllPayments()
        {
            try
            {

                return Ok(buisnessRuleEngineService.GetAllPayments());
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }

        /// <summary>
        /// Used to submit new Payment
        /// </summary>
        /// <param name="paymentDetails">payment Details</param>
        /// <returns>OK / BadResponse</returns>
        [HttpPost("SubmitPayment")]
        public ActionResult SubmitPayment(PaymentDetails paymentDetails)
        {
            try
            {
                bool result = buisnessRuleEngineService.SubmitPayment(paymentDetails);
                if (result)
                {
                    return Ok("sss");
                }
                return BadRequest();
            }
            catch (Exception )
            {
                return BadRequest();
            }

        }


    }
}
