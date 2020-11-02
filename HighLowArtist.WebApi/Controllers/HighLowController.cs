
using System.Threading.Tasks;
using HighLowArtist.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HighLowArtist.WebApi.Controllers
{
    [ApiController]
    public class HighLowController : ControllerBase
    {

        private readonly ILogger<HighLowController> _logger;
        private readonly IHighLowService _service;

        public HighLowController(ILogger<HighLowController> logger, IHighLowService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet("api/artists")]
        public async Task<ActionResult> GetArtists()
        {
            var artists = await _service.GetArtists();
            return Ok(artists);
        }
    }
}