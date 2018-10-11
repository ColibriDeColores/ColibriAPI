using System;
using ColibriAPI.Features.User.CreateUser;
using ColibriAPI.Features.User.GetUsers;
using ColibriAPI.Features.User.GetUsersById;
using ColibriAPI.Features.User.UpdateUser;
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
            var result = _mediatr.Send(new GetUsersModels.Query());
            return Ok(result);
        }

        // GET api/user/cbb0312a-1332-4412-afd3-51be3931f015
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var result = _mediatr.Send(new GetUsersByIdModels.Query(id));
            return Ok(result);
        }

        // POST api/user
        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModels.Command query)
        {
            var result = _mediatr.Send(query);
            return Ok(result);
        }

        // PUT api/user/cbb0312a-1332-4412-afd3-51be3931f015
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] UpdateUserModels.Command value)
        {
            return Ok();
        }

        // DELETE api/user/cbb0312a-1332-4412-afd3-51be3931f015
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            return Ok();
        }
    }
}
