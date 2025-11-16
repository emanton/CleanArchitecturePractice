

using BubberDinner.Application.Services.Authentication;
using BubberDinner.Contracts.Authentication;
using BuberDinner.Application.Services.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BubberDinner.Api.Controllers;

[ApiController]
[Route("auth")]
public class AuthenticationController : ControllerBase 
{
    private readonly IAuthenticationService _authenticationService;

    public AuthenticationController(IAuthenticationService authenticationService)
    {
        this._authenticationService = authenticationService;
    }

    [HttpPost("register")]
    public IActionResult Register(RegisterRequest request)
    {
        AuthenticationResult authResult = this._authenticationService.Register(request.FirstName, request.LastName, request.Email, request.Password);
        return Ok(authResult);
    }

    [HttpPost("login")]
    public IActionResult Login(LoginRequest request)
    {
        AuthenticationResult authResult = this._authenticationService.Login(request.Email, request.Password);
        return Ok(authResult);
    }
}