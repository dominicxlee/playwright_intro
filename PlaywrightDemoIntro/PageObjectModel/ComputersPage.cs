using Microsoft.Playwright;
using PlaywrightDemoIntro.PageObjectModel.Sections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro.PageObjectModel
{
    public class ComputersPage
    {
        public readonly IPage _page;

        public ComputersPage(IPage page)
        {
            _page = page;
        }
        public NavBar NavBar => new(_page);

    }
}
