using Microsoft.Playwright;
using PlaywrightDemoIntro.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro.Pages
{
    public class LoginPage
    {
        private readonly IPage _page;
        public LoginRepo _loginRepo;

        public LoginPage(IPage page)
        {
            _loginRepo = new LoginRepo(page);
            _page = page;
        }

        public async Task ClickLogin() => await _loginRepo.lnkLogin.ClickAsync();

        public async Task Login(string username, string password)
        {
            await _loginRepo.usernameInput.FillAsync(username);
            await _loginRepo.passwdInput.FillAsync(password);
            await _loginRepo.loginBtn.ClickAsync();
        }

        public async Task<bool> isEmployeeDetailsExist() => await _loginRepo.lnkEmplDetails.IsVisibleAsync();  
    }
}
