using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using System;

namespace netcore_facebook_auth.Controllers
{
    public class AccountController:Controller
    {
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public IActionResult ExternalSignIn(string provider)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<IActionResult> ExternalLoginCallBack()
        {
            throw new NotImplementedException();
        }
    }
}