using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MasterChef.Api.Controllers
{
    [Authorize]
    public class ControllerBase : Controller
    {
        public int UsuarioId
        {
            get { return GetUsuarioByID(); }
        }

        private int GetUsuarioByID()
        {
            var claim = ClaimsPrincipal.Current.Claims.FirstOrDefault(p => p.Type == ClaimTypes.Sid);

            return int.Parse(claim.Value);
        }
    }
}
