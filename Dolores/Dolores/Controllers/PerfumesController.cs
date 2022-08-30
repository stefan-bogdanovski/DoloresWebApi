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
	public class PerfumesController : ControllerBase
	{
		private readonly UseCaseHandler _handler;

		public PerfumesController(UseCaseHandler handler)
		{
			this._handler = handler;
		}

		// GET: api/<PerfumesController>
		[HttpGet]
		[AllowAnonymous]
		public IActionResult Get([FromQuery] BaseSearch search, [FromServices] IGetPerfumesQuery query)
		{
			var perfumes = this._handler.HandleQuery(query, search);
			return Ok(JsonConvert.SerializeObject(perfumes));
		}

		// GET api/<PerfumesController>/5
		[HttpGet("{id}")]
		public IActionResult Get(int id, [FromServices] IGetPerfumeQuery query)
		{
			var perfume = this._handler.HandleQuery(query, id);
			return Ok(JsonConvert.SerializeObject(perfume));
		}

		// POST api/<PerfumesController>
		[HttpPost]
		[Authorize]
		public IActionResult Post([FromBody] InsertPerfumeDto insertPerfumeDto, [FromServices] ICreatePerfumeCommand command)
		{
			this._handler.HandleCommand(command, insertPerfumeDto);
			return StatusCode(StatusCodes.Status201Created);
		}

		// PUT api/<PerfumesController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<PerfumesController>/5
		[HttpDelete("{id}")]
		public IActionResult Delete(int id, [FromServices] IDeletePerfumeCommand command)
		{
			this._handler.HandleCommand(command, id);
			return NoContent();
		}
	}
}
