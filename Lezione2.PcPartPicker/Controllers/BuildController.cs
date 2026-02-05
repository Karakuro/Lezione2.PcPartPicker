using Lezione2.PcPartPicker.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Lezione2.PcPartPicker.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BuildController : ControllerBase
    {
        [HttpGet]
        // GET api/Build
        public IActionResult GetAll()
        {
            return Ok(Database.Builds);
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult Get(Guid id)
        {
            var build = Database.Builds.SingleOrDefault(b => b.Id == id);
            return build != null ? Ok(build) : BadRequest($"Id {id} non trovato");
        }

        [HttpPost]
        public IActionResult CreateBuild()
        {
            PCBuild build = new PCBuild() { Id = Guid.NewGuid() };
            Database.Builds.Add(build);
            return Created("", build);
        }

        [HttpPost]
        [Route("{idBuild}/AddMB/{mbCode}")]
        public IActionResult AddMb(Guid idBuild, string mbCode)
        {
            PCBuild? build = Database.Builds.SingleOrDefault(b => b.Id == idBuild);
            if (build == null)
                return BadRequest($"Build ID {idBuild} not found");
            build?.Motherboard = Database.Motherboards.SingleOrDefault(m => m.Code == mbCode);
            if (build.Motherboard == null)
                return BadRequest($"Motherboard code {mbCode} not compatible");
            return Ok();
        }
    }
}
