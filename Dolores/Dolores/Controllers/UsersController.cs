namespace Dolores.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using Implementation;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Mvc;
	using Newtonsoft.Json;

	[Route("api/[controller]")]
	[ApiController]
	public class UsersController : ControllerBase
	{
		private readonly UseCaseHandler _handler;

		public UsersController(UseCaseHandler handler)
		{
			this._handler = handler;
		}

		// GET: api/<UsersController>
		[HttpGet]
		[Authorize]
		public IActionResult Get([FromQuery] BaseSearch baseSearch, [FromServices] IGetUsersQuery query)
		{
			var users = this._handler.HandleQuery(query, baseSearch);
			return Ok(JsonConvert.SerializeObject(users));
		}

		// GET api/<UsersController>/5
		[HttpGet("{id}")]
		[Authorize]
		public IActionResult Get(int id, [FromServices] IGetUserQuery query)
		{
			var user = this._handler.HandleQuery(query, id);
			return Ok(JsonConvert.SerializeObject(user));
		}

		// POST api/<UsersController>
		[HttpPost]
		public IActionResult Post([FromBody] string value)
		{
			return null;
		}

		// PUT api/<UsersController>/5
		[HttpPut("{id}")]
		public IActionResult Put(int id, [FromBody] string value)
		{
			return null;
		}

		// DELETE api/<UsersController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			return null;
		}
	}
}
