using DevIO.Api.Controllers;
using DevIO.Business.Interfaces;
using Elmah.Io.AspNetCore;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.Api.V2.Controllers
{
    [AllowAnonymous]
    [ApiVersion("2.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class TesteController : MainController
    {
        private readonly ILogger _logger;

        public TesteController(INotificador notificador, IUser appUser, ILogger<TesteController> logger) : base(notificador, appUser)
        {
            _logger = logger;
        }

        [HttpGet]
        public string RotaAleatoria()
        {

            var secret = "o&W$SuESmsgY%dJiHYs^m6QdFXM8^D89%XNu336oxs^yx9cA5@eRKd^UrnRMM8wf@RRNrCB";

            return secret;
        }
    }
}
