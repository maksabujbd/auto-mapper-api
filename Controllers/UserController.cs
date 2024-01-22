using AutoMapper.API.Model.DbSet;
using AutoMapper.API.Model.Dtos.Requests;
using AutoMapper.API.Model.Dtos.Responses;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController(ILogger<UserController> logger, IMapper mapper) : ControllerBase
{
    [HttpGet]
    public IActionResult GetUser()
    {
        var user = new User
        {
            Email = "test@test.com",
            FirstName = "Abdul",
            LastName = "Kader",
            Id = Guid.NewGuid(),
            PostCode = "3500",
            StreetAddress = "Cumilla"
        };
        var returnUser = mapper.Map<GetUserResponse>(user);
        return Ok(returnUser);
    }

    [HttpPost]
    public IActionResult CreateUser([FromBody]CreateUserRequest request)
    {
        var newUser = mapper.Map<User>(request);
        return Ok(newUser);
    }
}