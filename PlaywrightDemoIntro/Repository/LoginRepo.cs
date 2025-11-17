using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro.Repository
{
    public class LoginRepo
    {
        public IPage _page;
        public readonly ILocator lnkLogin;
        public readonly ILocator usernameInput;
        public readonly ILocator passwdInput;
        public readonly ILocator loginBtn;
        public readonly ILocator lnkEmplDetails;

        public LoginRepo(IPage page)
        {
            _page = page;
            lnkLogin = _page.GetByText("Login");
            usernameInput = _page.Locator("#UserName");
            passwdInput = _page.Locator("//input[@id='Password']");
            loginBtn = _page.Locator("//input[@id='loginIn']");
            lnkEmplDetails = _page.Locator("text='Employee Details'");


        }
    }
}
