using INTEGRATION_LAYER_01.Model;
using INTEGRATION_LAYER_01.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace INTEGRATION_LAYER_01.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class SdevController : ControllerBase
    {
        private readonly ILogger<SdevController> _logger;

        private ISDevBusiness _sdevBusiness;

        public SdevController(ILogger<SdevController> logger, ISDevBusiness sdevBusiness)
        {
            _logger = logger;
            _sdevBusiness = sdevBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sdevBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var sdev = _sdevBusiness.FindById(id);
            if (sdev == null) return NotFound();
            return Ok(sdev);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Sdev sdev)
        {
            if (sdev == null) return BadRequest();
            return Ok(_sdevBusiness.Create(sdev));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Sdev sdev)
        {
            if (sdev == null) return BadRequest();
            return Ok(_sdevBusiness.Update(sdev));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _sdevBusiness.Delete(id);
            return NoContent();
        }

    }
}
