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
	public class BrandsController : ControllerBase
	{
		private readonly UseCaseHandler _handler;

		public BrandsController(UseCaseHandler handler)
		{
			this._handler = handler;
		}

		// GET: api/<BrandsController>
		[HttpGet]
		public IActionResult Get([FromQuery] BaseSearch search, [FromServices] IGetBrandsQuery query)
		{
			var brands = this._handler.HandleQuery(query, search);
			return Ok(JsonConvert.SerializeObject(brands));
		}

		// GET api/<BrandsController>/5
		[HttpGet("{id}")]
		[Authorize]
		public IActionResult Get(int id, [FromServices] IGetBrandQuery query)
		{
			var brand = this._handler.HandleQuery(query, id);
			return Ok(JsonConvert.SerializeObject(brand));
		}

		// POST api/<BrandsController>
		[HttpPost]
		[Authorize]
		public IActionResult Post([FromBody] InsertBrandDto insertBrandDto, [FromServices] ICreateBrandCommand command)
		{
			this._handler.HandleCommand(command, insertBrandDto);
			return StatusCode(StatusCodes.Status201Created);
		}

		// PUT api/<BrandsController>/5
		[HttpPut("{id}")]
		public void Put(int id, [FromBody] string value)
		{
		}

		// DELETE api/<BrandsController>/5
		[HttpDelete("{id}")]
		[Authorize]
		public IActionResult Delete(int id, [FromServices] IDeleteBrandCommand command)
		{
			_handler.HandleCommand(command, id);
			return StatusCode(StatusCodes.Status204NoContent);
		}
	}
}
