using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Dtos;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ClubsController : ControllerBase
    {
        /// <summary>
        /// Returns a list of clubs in your bag
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(200, Type = typeof(List<ClubDto>))]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new OkObjectResult(
                new []
                {
                    new ClubDto {Name = "Sand wedge", Description = "Sand wedge", ClubType = ClubType.Iron},
                    new ClubDto {Name = "Pitching wedge", Description = "Pitching wedge", ClubType = ClubType.Iron},
                    new ClubDto {Name = "9-iron", Description = "9-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "8-iron", Description = "8-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "7-iron", Description = "7-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "6-iron", Description = "6-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "5-iron", Description = "5-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "4-iron", Description = "4-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "3-iron", Description = "3-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "2-iron", Description = "2-iron", ClubType = ClubType.Iron},
                    new ClubDto {Name = "3-wood", Description = "3-wood", ClubType = ClubType.Wood},
                    new ClubDto {Name = "Driver", Description = "Driver", ClubType = ClubType.Wood},
                    new ClubDto {Name = "Putter", Description = "Putter", ClubType = ClubType.Putter}
                });
        }

        /// <summary>
        /// You asked for a club, time for your caddy to get it out
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [ProducesResponseType(200, Type = typeof(ClubDto))]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            var club = new ClubDto
            {
                ClubType = ClubType.Iron,
                Description = "Trusty 7-iron",
                Name = "7-iron"
            };
            return new OkObjectResult(club);
        }

        /// <summary>
        /// Bought a new set?  Better add them to your bag first
        /// </summary>
        /// <param name="club"></param>
        /// <returns></returns>
        [ProducesResponseType(200, Type = typeof(ClubDto))]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPost]
        public IActionResult Post([FromBody] ClubDto club)
        {
            return new OkObjectResult(club);
        }

        /// <summary>
        /// Hit clubhouse after the round and ready to swap one out of your bag?
        /// </summary>
        /// <param name="id"></param>
        /// <param name="club"></param>
        /// <returns></returns>
        [ProducesResponseType(204)]
        [ProducesResponseType(401)]
        [ProducesResponseType(404)]
        [ProducesResponseType(500)]
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] ClubDto club)
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