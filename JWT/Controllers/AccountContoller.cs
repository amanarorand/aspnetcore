using Microsoft.AspNetCore.Mvc;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Collections.Generic;
using System;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Mvc.Routing;

namespace JWT.Contollers
{
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        
        public object GenerateJwtToken()
        {
            var claims = new List<Claim>(){
                new Claim(JwtRegisteredClaimNames.Sub, "email"),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(ClaimTypes.NameIdentifier, "userid")
            };
            var expires = DateTime.Now.AddMinutes(5);
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("SOME_RANDOM_KEY_DO_NOT_SHARE"));
            var token = new JwtSecurityToken("http://localhost:5000",
            "http://localhost:5000",
            claims,
            expires: expires,
            signingCredentials: new SigningCredentials(key, SecurityAlgorithms.HmacSha256));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public IActionResult getToken()
        {
            return Json(GenerateJwtToken());
        }
    }
}
