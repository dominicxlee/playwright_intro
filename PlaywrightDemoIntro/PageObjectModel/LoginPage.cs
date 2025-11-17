using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro.PageObjectModel
{
    public class LoginPage
    {
        public readonly IPage _page;

        public LoginPage(IPage page)
        {
            _page = page;
        }

        private ILocator UserName => _page.GetByPlaceholder("Enter Username");

        private ILocator PassWord => _page.GetByPlaceholder("Enter Password");

        private ILocator loginButton => _page.GetByTestId("login-button");

        public async Task Login(string username, string password)
        {
            await UserName.FillAsync(username);
            await PassWord.FillAsync(password);
            await loginButton.ClickAsync();
        }

        public async Task GoTo()
        {
            await _page.GotoAsync("https://commitquality.com/login");
        }






    }
}
