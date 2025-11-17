using Microsoft.Playwright;
using PlaywrightDemoIntro.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro.TestCases
{
    public class LoginTest
    {
        private IPage _page;
        private IBrowser _browser;
        private IPlaywright _playwright;
        private LoginPage _loginPage;

        [SetUp]
        public async Task Setup()
        {
            _playwright = await Playwright.CreateAsync();
            _browser = await _playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false
            });
            

            _page = await _browser.NewPageAsync();

            await _page.GotoAsync("http://eaapp.somee.com/");

            // Initialize the Page Object
            _loginPage = new LoginPage(_page);
        }
        

        [Test]
        public async Task LoginDemoTest()
        {
            await _loginPage.ClickLogin();
            await _loginPage.Login("admin", "password");
            await _loginPage.isEmployeeDetailsExist();


        }
    }
}
