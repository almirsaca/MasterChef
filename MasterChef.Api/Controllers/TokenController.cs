using MasterChef.Domain.Application;
using MasterChef.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace FiapApiToken.Controllers
{
    [Route("/token")]
    public class TokenController : Controller
    {
        private readonly IUsuarioService UsuarioService;

        public TokenController(IUsuarioService usuarioService)
        {
            UsuarioService = usuarioService;
        }

        [HttpPost]
        public IActionResult Create(string email, string password)
        {
            var usuario = UsuarioService.GeUsuarioByEmailAndSenha(email, password);

            if (usuario != null)
            {
                var token = GenerateToken(usuario);
                //Salvar no DB
                return Ok(new { Nome = usuario.Nome, Token = token });
            }
            return BadRequest();
        }

        private string GenerateToken(Usuario usuario)
        {
            var claims = new Claim[]
            {
                new Claim(ClaimTypes.Sid, usuario.UsuarioID.ToString()),
                new Claim(ClaimTypes.Name, usuario.Nome),
                new Claim(JwtRegisteredClaimNames.Nbf, new DateTimeOffset(DateTime.Now).ToUnixTimeSeconds().ToString()),
                new Claim(JwtRegisteredClaimNames.Exp, new DateTimeOffset(DateTime.Now.AddDays(1)).ToUnixTimeSeconds().ToString()),
            };

            var token = new JwtSecurityToken(
                new JwtHeader(new SigningCredentials(
                    new SymmetricSecurityKey(Encoding.UTF8.GetBytes("the secret that needs to be at least 16 characeters long for HmacSha256")),
                                             SecurityAlgorithms.HmacSha256)),
                new JwtPayload(claims));

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}
