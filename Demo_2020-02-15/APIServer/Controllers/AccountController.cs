using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace TetrisApiServer.Controllers
{
    [Produces("application/json")]
    [Route("api/Account/Create")]
    public class AccountController : Controller
    {
        [HttpPost]
        public async Task<CreateuserRes> Process([FromBody] CreateuserReq request)
        {
            Debug.WriteLine("Process Function Called");
            return new CreateuserRes() { Result = (short)0 };
        }
                

        public class CreateuserReq
        {
            public string UserID;
            public string UserPW;       
        }
         
        public class CreateuserRes 
        {
             public short Result; 
        }
    }
}

/*TODO
 * 
 * [ Controller로 만들것들 ]
 *  게임 데이터 로딩
 *  매칭 요청
 *  매칭 요청 결과 안내
 * 
 * [완성할 기능]
 * 계정생성 기능 만들기
 * 
 * [참고사항]
 * 포스트맨 이용하기
 *
 *  컨트롤러와 404에러 관련글
 * https://docs.microsoft.com/ko-kr/aspnet/core/web-api/action-return-types?view=aspnetcore-2.2
 * */
