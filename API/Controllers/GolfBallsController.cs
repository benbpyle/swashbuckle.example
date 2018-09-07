using System.Collections.Generic;
using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "Golf Balls")]
    public class GolfBallsController : ControllerBase
    {
        /// <summary>
        /// Returns a list of clubs in your bag
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<GolfBallDto>))]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new OkObjectResult(
                new []
                {
                    new GolfBallDto { Brand = "Titleist", Number = 1 },
                    new GolfBallDto { Brand = "Titleist", Number = 1 },
                    new GolfBallDto { Brand = "Titleist", Number = 2 },
                    new GolfBallDto { Brand = "Titleist", Number = 2 },
                });
        }

        /// <summary>
        /// You asked for a club, time for your caddy to get it out
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(200, Type = typeof(GolfBallDto))]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var ball = new GolfBallDto
            {
                Number   = 1,
                Brand = "Titleist"
            };
            return new OkObjectResult(ball);
        }

        /// <summary>
        /// Bought a new set?  Better add them to your bag first
        /// </summary>
        /// <param name="ball"></param>
        /// <returns></returns>
        [ProducesResponseType(200, Type = typeof(GolfBallDto))]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPost]
        public IActionResult Post([FromBody] GolfBallDto ball)
        {
            return new OkObjectResult(ball);
        }

        /// <summary>
        /// Hit clubhouse after the round and ready to swap one out of your bag?
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ball"></param>
        /// <returns></returns>
        [ProducesResponseType(204)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] GolfBallDto ball)
        {
            return new NoContentResult();
        }

        /// <summary>
        /// Rough round? Lose that one in the lake?
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(204)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return new NoContentResult();
        }
        
    }
}