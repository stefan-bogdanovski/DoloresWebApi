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
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;
	using Newtonsoft.Json;

	[Route("api/[controller]")]
	[ApiController]
	public class OrdersController : ControllerBase
	{
		private readonly UseCaseHandler _handler;

		public OrdersController(UseCaseHandler handler)
		{
			this._handler = handler;
		}

		// GET: api/<OrdersController>
		[HttpGet]
		[Authorize]
		public IActionResult Get([FromQuery] BaseSearch search, [FromServices] IGetOrdersQuery query)
		{
			var orders = this._handler.HandleQuery(query, search);
			return Ok(JsonConvert.SerializeObject(orders));
		}

		// GET api/<OrdersController>/5
		[HttpGet("{id}")]
		public string Get(int id)
		{
			return "value";
		}

		// POST api/<OrdersController>
		[HttpPost]
		[Authorize]
		public IActionResult Post([FromBody] InsertOrderDto insertOrderDto, [FromServices] ICreateOrderCommand command)
		{
			this._handler.HandleCommand(command, insertOrderDto);
			return StatusCode(StatusCodes.Status201Created);
		}

		// PUT api/<OrdersController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<OrdersController>/5
		[HttpDelete("{id}")]
		public void Delete(int id)
		{
		}
	}
}
