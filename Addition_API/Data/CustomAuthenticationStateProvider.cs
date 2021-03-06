using Microsoft.AspNetCore.Components.Authorization;
using System;
using System.Security.Claims;
using System.Threading.Tasks;
using Blazored.SessionStorage;


namespace Addition_API.Data
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        private ISessionStorageService _sessionStorageService;

        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService)
        {
            _sessionStorageService = sessionStorageService;
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            string UserId = await _sessionStorageService.GetItemAsync<string>("UserId");

            ClaimsIdentity identity;

            if (UserId != null)
            {
                if (UserId != "")
                {
                    UserVM oUser = getUserByUserId(UserId);

                    if (oUser.UserId != "")
                    {
                        identity = new ClaimsIdentity(new[] {
                            //new Claim("UserToken",oUser.UserToken),
                            //new Claim(ClaimTypes.Name,oUser.UserName),
                            //new Claim(ClaimTypes.Email,oUser.EMail),
                            new Claim("UserId",oUser.UserId)
                        }, "apiauth_type");
                    }
                    else
                    {
                        identity = new ClaimsIdentity();
                    }
                }
                else
                {
                    identity = new ClaimsIdentity();
                }
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(user));
        }

        private UserVM getUserByUserId(string UserId)
        {
            UserVM oUser = new UserVM();
            //if (UserToken == "94607556-FE6D-46DB-93B8-42873170404E")
            if (UserId == "michelle")
            {
                oUser = fakeSetUserData();
            }
            return oUser;
        }

        public void MarkUserAsLogin(UserVM oUser)
        {
            ClaimsIdentity identity;

            if (oUser != null)
            {
                if (doLogin(ref oUser))
                {
                    identity = new ClaimsIdentity(new[] {
                        //new Claim("UserToken",oUser.UserToken),
                        //new Claim(ClaimTypes.Name,oUser.UserName),
                        //new Claim(ClaimTypes.Email,oUser.EMail),
                        new Claim("UserId",oUser.UserId)
                    }, "apiauth_type");
                    _sessionStorageService.SetItemAsync<string>("UserId", oUser.UserId);
                }
                else
                {
                    identity = new ClaimsIdentity();
                }
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var user = new ClaimsPrincipal(identity);
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

        private bool doLogin(ref UserVM oUser)
        {
            bool rc = false;
            //模擬資料庫驗證帳號密碼，取得User資訊
            if ((oUser.UserId == "michelle") && (oUser.PW == "12345"))
            {
                //模擬驗證成功，將使用者資訊放入oUser中
                oUser = fakeSetUserData();
                rc = true;
            }
            else
            {
                throw new Exception("登入失敗，請確認您的帳號或密碼是否正確");
            }
            return rc;
        }

        /// <summary>
        /// 模擬從資料庫取資料放入UserVM物件中
        /// </summary>
        /// <returns>
        /// 成功回傳UserVM物件
        /// </returns>
        private UserVM fakeSetUserData()
        {
            UserVM oUser = new UserVM();
            oUser.UserId = "michelle";
            oUser.PW = "12345";
            //oUser.UserName = "Michelle";
            //oUser.EMail = "xxx@gmail.com";
            //oUser.UserToken = "94607556-FE6D-46DB-93B8-42873170404E";
            return oUser;
        }

        public void MarkUserAsLogout()
        {
            ClaimsIdentity identity = new ClaimsIdentity();
            identity = new ClaimsIdentity();
            var user = new ClaimsPrincipal(identity);
            _sessionStorageService.ClearAsync();
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(user)));
        }

    }
}