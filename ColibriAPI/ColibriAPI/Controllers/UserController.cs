using System;
using ColibriAPI.Features.CreateUser;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace ColibriAPI.Controllers
{
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediatr;

        public UserController(IMediator mediatr)
        {
            _mediatr = mediatr;
        }

        // GET api/user
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new string[] { "value1", "value2" });
        }

        // GET api/user/cbb0312a-1332-4412-afd3-51be3931f015
        [HttpGet("{id}")]
        public IActionResult Get([FromQuery] Guid id)
        {

            return Ok("value");
        }

        // POST api/user
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModels.Query query)
        {
            return Ok(_mediatr.Send(query));
        }

        // PUT api/user/cbb0312a-1332-4412-afd3-51be3931f015
        [HttpPut("{id}")]
        public IActionResult Put([FromQuery] Guid id, [FromBody] string value)
        {
            return Ok();
        }

        // DELETE api/user/cbb0312a-1332-4412-afd3-51be3931f015
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
