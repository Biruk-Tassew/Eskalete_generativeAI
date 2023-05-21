using API.Controllers;
using Microsoft.AspNetCore.Mvc;
using TM.Application.Features.User.CQRS;
using TM.Application.Features.User.DTOs;
using TM.Application.Features.User.CQRS.Commands;
using TM.Application.Features.User.CQRS.Queries;

namespace TM.API.Controllers
{
    public class UserController : BaseApiController
    {
        [HttpGet] //api/Tasks
        public async Task<IActionResult> GetAllUser()
        {
            return HandleResult(await Mediator.Send(new GetUserListQuery()));
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetTasks(int id)
        {
            return HandleResult(await Mediator.Send(new GetUserDetailQuery { Id = id }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(RegistrationDto registrationDto)
        {
            return HandleResult(await Mediator.Send(new CreateUserCommand { RegistrationDto = registrationDto }));
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthenticationDto authenticationDto)
        {
            return HandleResult(await Mediator.Send(new LoginCommand { authenticationDto = authenticationDto }));
        }


        [HttpPut]
        public async Task<IActionResult> UpdateRate(UpdateUserDto updateUser)
        {
            return HandleResult(await Mediator.Send(new UpdateUserCommand { UpdateUserDto = updateUser }));
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            return HandleResult(await Mediator.Send(new DeleteUserCommand { Id = id }));
        }
    }
}
