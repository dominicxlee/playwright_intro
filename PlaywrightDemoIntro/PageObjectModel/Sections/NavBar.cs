using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro.PageObjectModel.Sections
{
    public class NavBar
    {
        public readonly IPage _page;
        public NavBar(IPage page) {
            
            _page = page;
        
        }

        public ILocator logOutButton => _page.GetByTestId("navbar-logout");
    }
}
