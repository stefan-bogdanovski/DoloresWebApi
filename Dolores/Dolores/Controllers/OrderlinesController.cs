namespace Dolores.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Application.UseCases.Commands;
	using Application.UseCases.Dto;
	using Application.UseCases.Dto.Filtering;
	using Application.UseCases.Queries;
	using Implementation;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using Newtonsoft.Json;

	[Route("api/[controller]")]
	[ApiController]
	public class OrderlinesController : ControllerBase
	{
		private readonly UseCaseHandler _handler;

		public OrderlinesController(UseCaseHandler handler)
		{
			this._handler = handler;
		}

		// GET: api/<OrderlinesController>
		[HttpGet]
		public IActionResult Get([FromQuery] OrderlineSearch search, [FromServices] IGetOrderlinesQuery query)
		{
			var orderlines = this._handler.HandleQuery(query, search);
			return Ok(JsonConvert.SerializeObject(orderlines));
		}

		// GET api/<OrderlinesController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<OrderlinesController>
		[HttpPost]
		public IActionResult Post([FromBody] InsertOrderlineDto insertOrderlineDto, [FromServices] ICreateOrderlineCommand command)
		{
			this._handler.HandleCommand(command, insertOrderlineDto);
			return StatusCode(StatusCodes.Status201Created);
		}

		// PUT api/<OrderlinesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<OrderlinesController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id, [FromServices] IDeleteOrderlineCommand command)
		{
			this._handler.HandleCommand(command, id);
			return NoContent();
		}
	}
}
