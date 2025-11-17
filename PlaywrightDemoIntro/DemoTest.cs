using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaywrightDemoIntro
{
    public class DemoTest
    {
        [Test]
        public async Task ScreenshotTestDemo()
        {
            //Playwright
            using var playwright = await Playwright.CreateAsync();

            await using var browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
            });

            var page = await browser.NewPageAsync();

            await page.GotoAsync("http://eaapp.somee.com/");

            await page.GetByText("Login").ClickAsync();

            await page.ScreenshotAsync(new PageScreenshotOptions
            {
                Path = "eapp.jpg",
            });

            await page.FillAsync("#UserName", "admin");
            await page.FillAsync("#Password", "password");
            await page.Locator("//input[@id='loginIn']").ClickAsync();
            var isExist = await page.Locator("text='Employee Details'").IsVisibleAsync();
            Assert.IsTrue(isExist);


        }
    }
}
