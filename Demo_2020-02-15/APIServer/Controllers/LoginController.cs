using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace APIServer.Controllers
{
    [Produces("application/json")]
    [Route("api/Login")]
    [ApiController]
    public class LoginController : Controller
    {
        [HttpPost]
        public async Task<LoginRes> Process([FromBody] LoginReq request)
        {
            var response = new LoginRes() 
            { 
                Result = 1, 
                AuthToken = "fake",
                GameServerIP = LoginServer.ServerOpt.GameServerIP,
                GameServerPort = (UInt16)LoginServer.ServerOpt.GameServerPort,
            };

            var authToken = CreateAuthToken();

            var result = await DBRedis.SetValue(request.UserID, authToken);

            response.AuthToken = authToken;
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
        public int Result { get; set; }
        public string AuthToken { get; set; }

        public string GameServerIP { get; set; }
        public UInt16 GameServerPort { get; set; }
    }
}