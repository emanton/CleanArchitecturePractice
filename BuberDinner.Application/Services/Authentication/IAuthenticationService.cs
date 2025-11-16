namespace BuberDinner.Application.Services.Authentication;

using BubberDinner.Application.Services.Authentication;

public interface IAuthenticationService
{
    AuthenticationResult Login(string email, string token);
    AuthenticationResult Register(string firstName, string lastName, string email, string token);
}