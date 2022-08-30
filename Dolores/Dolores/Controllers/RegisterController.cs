namespace Dolores.Controllers
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Threading.Tasks;
	using Application.UseCases.Commands;
	using Application.UseCases.Dto;
	using DataAccess;
	using Implementation;
	using Implementation.UseCases.Commands;
	using Microsoft.AspNetCore.Authorization;
	using Microsoft.AspNetCore.Http;
	using Microsoft.AspNetCore.Mvc;

	[Route("api/[controller]")]
	[ApiController]
	public class RegisterController : ControllerBase
	{
		private readonly IRegisterUserCommand _command;
		private readonly UseCaseHandler _handler;

		public RegisterController(UseCaseHandler handler, IRegisterUserCommand command)
		{
			_handler = handler;
			_command = command;
		}

		// POST api/<RegisterController>
		[HttpPost]
		[AllowAnonymous]
		public IActionResult Post([FromBody] RegisterUserDto registerUserDto)
		{
			this._handler.HandleCommand(_command, registerUserDto);
			return StatusCode(StatusCodes.Status201Created);
		}
	}
}
