using FluentAssertions;

namespace TestTask.Core.UI.Pages.Home
{
    public static class HomeAsserter
    {
        public static void IsLogoPresent(this IHomePage page)
        {
            page.IsLogoPresent().Should().BeTrue();
        }
    }
}
