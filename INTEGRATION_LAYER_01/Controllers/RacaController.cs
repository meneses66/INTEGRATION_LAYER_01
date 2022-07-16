using INTEGRATION_LAYER_01.Model;
using INTEGRATION_LAYER_01.Business;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace INTEGRATION_LAYER_01.Controllers
{
    [ApiVersion("1")]
    [ApiController]
    [Route("api/[controller]/v{version:apiVersion}")]
    public class RacaController : ControllerBase
    {
        private readonly ILogger<RacaController> _logger;

        private IRacaBusiness _racaBusiness;

        public RacaController(ILogger<RacaController> logger, IRacaBusiness racaBusiness)
        {
            _logger = logger;
            _racaBusiness = racaBusiness;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_racaBusiness.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var raca = _racaBusiness.FindById(id);
            if (raca == null) return NotFound();
            return Ok(raca);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Raca raca)
        {
            if (raca == null) return BadRequest();
            return Ok(_racaBusiness.Create(raca));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Raca raca)
        {
            if (raca == null) return BadRequest();
            return Ok(_racaBusiness.Update(raca));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _racaBusiness.Delete(id);
            return NoContent();
        }

    }
}
