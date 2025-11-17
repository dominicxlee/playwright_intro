using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Playwright;

namespace PlaywrightDemoIntro
{
    public class Login : PageTest
    {
        [Test]
        public async Task LoginTest()
        {
            await Page.GotoAsync("https://commitquality.com/login");

            await Page.GetByPlaceholder("Enter Username").FillAsync("test");

            await Page.GetByPlaceholder("Enter Password").FillAsync("test");

            await Page.GetByTestId("login-button").ClickAsync();

            await Expect(Page.GetByText("Logout")).ToBeVisibleAsync();



        }

    }
}
