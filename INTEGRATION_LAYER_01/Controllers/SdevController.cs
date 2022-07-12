using INTEGRATION_LAYER_01.Model;
using INTEGRATION_LAYER_01.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace INTEGRATION_LAYER_01.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SdevController : ControllerBase
    {
        private readonly ILogger<SdevController> _logger;

        private ISDevService _sdevService;

        public SdevController(ILogger<SdevController> logger, ISDevService sdevService)
        {
            _logger = logger;
            _sdevService = sdevService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_sdevService.FindAll());
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            var person = _sdevService.FindById(id);
            if (person == null) return NotFound();
            return Ok(person);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Sdev sdev)
        {
            if (sdev == null) return BadRequest();
            return Ok(_sdevService.Create(sdev));
        }

        [HttpPut]
        public IActionResult Put([FromBody] Sdev sdev)
        {
            if (sdev == null) return BadRequest();
            return Ok(_sdevService.Update(sdev));
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long id)
        {
            _sdevService.Delete(id);
            return NoContent();
        }

    }
}
