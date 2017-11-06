using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace VASystem.Web.Controllers
{
    [Produces("application/json")]
    [Route("api/token")]
    [Authorize]
    public class TokenController : Controller
    {
    }
}