using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TetrisApiServer.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    [ApiController]
    public class LoginController : Controller
    {
        [HttpPost]
        public async Task<LoginRes> Process([FromBody] LoginReq request)
        {
            //var tick = DateTime.Now.Ticks.ToString();              
            var response = new LoginRes() 
            { Result = "0", 
                AuthToken = "fake",
                LobbyServerIP = APIServer.ServerOpt.LobbyServerIP,
                LobbyServerPort = APIServer.ServerOpt.LobbyServerPort,
            };

            return response;                        
        }

        string CreateAuthToken()
        {
            string token = Convert.ToBase64String(Guid.NewGuid().ToByteArray());
            return token;
        }
                
    }

    public class LoginReq
    {
        public string UserID { get; set; }
        public string UserPW { get; set; }
    }

    public class LoginRes
    {
        public string Result { get; set; }
        public string AuthToken { get; set; }

        public string LobbyServerIP { get; set; }
        public UInt16 LobbyServerPort { get; set; }
    }
}