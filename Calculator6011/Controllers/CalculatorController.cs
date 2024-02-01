
using Microsoft.AspNetCore.Mvc;

namespace MyApp.Namespace
{
    [Route("[controller]/[action]")]
    [ApiController]

    public class CalculatorController : ControllerBase
    {
        [HttpGet]
        public decimal Add(decimal a, decimal b )
        {

            return a+b;
        }
    [HttpGet]
    public decimal Sub(decimal a, decimal b)
    {

     return a-b;
    }
    
    [HttpGet]
    public decimal Multi(decimal a, decimal b)
    {
        return a*b;   
    }
    [HttpGet]
    public ActionResult division(decimal a, decimal b)
    {
        if(b==0){

             return BadRequest("cannot divide by zero");
        }
        decimal result =a/b;
        return Ok(result);
    }
    // GET: Calculator-api

    [HttpGet]

    public ActionResult Modulous(decimal a, decimal b)
{
    if(b ==0){
        return BadRequest("Cannot calculate modulo with zero divisor");
    }
    decimal remainder =a%b;
    return Ok(remainder);
}
}
}
