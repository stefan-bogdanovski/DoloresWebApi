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
	public class LogsController : ControllerBase
	{
		private readonly UseCaseHandler _handler;

		public LogsController(UseCaseHandler handler)
		{
			this._handler = handler;
		}

		// GET: api/<LogsController>
		[HttpGet]
		public IActionResult Get([FromServices] IGetLogsQuery query, [FromQuery] LogSearch search)
		{
			var datetime = DateTime.Now;
			var logs = this._handler.HandleQuery(query, search);
			return Ok(JsonConvert.SerializeObject(logs));
		}

		// GET api/<LogsController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<LogsController>
		[HttpPost]
		public void Post([FromBody] string value)
		{
		}

		// PUT api/<LogsController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<LogsController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
