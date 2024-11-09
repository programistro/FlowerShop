using System.Security.Claims;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FlowerShop.Controllers;

[Microsoft.AspNetCore.Mvc.Route("/[controller]")]
[ApiController]
public class AuthController : ControllerBase
{
    [HttpGet("singin")]
    public async Task<ActionResult> Singin(string email, string role)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimsIdentity.DefaultNameClaimType, email),
            new Claim(ClaimsIdentity.DefaultRoleClaimType, role),
            new (ClaimTypes.Role, role),
            new (ClaimTypes.Name, email)
        };
        var claimsIdentity = new ClaimsIdentity(claims, "Cookie");
        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
        await HttpContext.SignInAsync(claimsPrincipal);

        return Redirect("/");
    }
    
    [HttpGet("singinAdmin")]
    public async Task<ActionResult> SinginAdmin(string email)
    {
        var claims = new List<Claim>
        {
            new Claim(ClaimsIdentity.DefaultNameClaimType, email),
            new Claim(ClaimsIdentity.DefaultRoleClaimType, "admin"),
            new (ClaimTypes.Role, "admin"),
            new (ClaimTypes.Name, email)
        };
        var claimsIdentity = new ClaimsIdentity(claims, "Cookie");
        var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);
        await HttpContext.SignInAsync(claimsPrincipal);

        return Redirect("/");
    }
    
    [AllowAnonymous]
    [HttpGet("signout")]
    public async Task<ActionResult> signout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

        return Redirect("/");
    }
}