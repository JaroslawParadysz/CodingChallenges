using Microsoft.AspNetCore.Mvc;
using WebChallenges.Domain;

namespace WebChallenges.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebChallengesController : ControllerBase
    {
        private readonly IRepository _repository;

        public WebChallengesController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet("{invoiceId}")]
        public IActionResult GetTotal(int invoiceId)
        {
            
            decimal? result = _repository.GetTotal(invoiceId);
            return Ok(result);
        }

        [HttpGet]
        public IActionResult GetTotalOfUnpaid()
        {
            decimal result = _repository.GetTotalOfUnpaid();
            return Ok(result);
        }
    }
}