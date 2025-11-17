using PlaywrightDemoIntro.PageObjectModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro
{
    public class LoginPageObjectModel : PageTest
    {
        private LoginPage _loginPage;
        private ComputersPage _computersPage;

        [SetUp]
        public void TestSetup()
        {
            _loginPage = new LoginPage(Page);
            _computersPage = new ComputersPage(Page);
            
        }


        [Test]
        public async Task LoginTest()
        {
            await _loginPage.GoTo();
            //await Page.Clock.
            await _loginPage.Login("test", "test");
            await Page.PauseAsync();
            await Expect(_computersPage.NavBar.logOutButton).ToBeVisibleAsync();
            await Page.PauseAsync();


        }
    }
}
