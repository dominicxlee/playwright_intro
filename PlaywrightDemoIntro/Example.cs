using Microsoft.Playwright;

namespace PlaywrightDemoIntro
{
    [Parallelizable(ParallelScope.Self)]
    [TestFixture]
    public class Example : PageTest
    {
        [Test]
        public async Task HomepageHasPlaywrightInTitleAndGetStartedLinkLinkingtoTheIntroPage()
        {
            await Page.GotoAsync("https://playwright.dev");

            

            var envVariable = Environment.GetEnvironmentVariable("SUBSCRIBE");

            var getParam = TestContext.Parameters["SQUATHUB"];

            // Expect a title "to contain" a substring.
            await Expect(Page).ToHaveTitleAsync(new Regex("Playwright"));

            // create a locator
            var getStarted = Page.Locator("text=Get Started");

            // Expect an attribute "to be strictly equal" to the value.
            await Expect(getStarted).ToHaveAttributeAsync("href", "/docs/intro");

            // Click the get started link.
            await getStarted.ClickAsync();

            // Expects the URL to contain intro.
            await Expect(Page).ToHaveURLAsync(new Regex(".*intro"));
        }

        [Test]
        public async Task Assertions()
        {
            await Page.GotoAsync("https://commitquality.com");

            await Expect(Page).ToHaveTitleAsync(new Regex("CommitQuality"));

            var firstRowName = Page.GetByTestId("name").First;

            await Expect(firstRowName).ToHaveTextAsync("Product 3");

        }
        [Test]
        //Test declarations
        public async Task PopUpTest()
            {
            //pop up async handler
            await Page.AddLocatorHandlerAsync(Page.GetByText("Random Popup"), async () =>
                {
                    await Page.GetByText("Close").ClickAsync();
                });

            await Page.GotoAsync("https://commitquality.com/practice-random-popup");

            await Task.Delay(6000);

            await Page.GetByTestId("accordion-1").ClickAsync();

            await Task.Delay(5000);

            }

        
        [Test]
        //Test declarations
        public async Task FileUploadTest()
        {
            await Page.GotoAsync("https://commitquality.com/practice-file-upload");
            await Task.Delay(4000);
            await Page.PauseAsync();

            Page.Dialog += async (_, dialog) =>
            {
                await Page.PauseAsync();
                await dialog.AcceptAsync();
            };

            //await Page.Locator("//input[@type='file']").ClickAsync();
            
            await Page.Locator("//input[@type='file']").SetInputFilesAsync("C:\\Users\\domin\\source\\repos\\PlaywrightDemoIntro\\readme.txt");
            await Task.Delay(4000);

            await Page.GetByText("Submit").ClickAsync();

        }
    }
}
