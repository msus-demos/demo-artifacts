using System;
using MicrosoftFieldDemos.Artifacts;
using Xunit;

namespace MicrosoftFieldDemos.Artifacts.Tests
{
    // This is my test class
    public class DemoContentProviderTests
    {
        [Fact]
        public void GetDemoContent_WithoutName_ReturnsRandomName()
        {
            var provider = new DemoContentProvider();
            var content = provider.GetDemoContent();

            Assert.False(String.IsNullOrEmpty(content.Name));
            Assert.False(String.IsNullOrEmpty(content.Company));
            Assert.False(String.IsNullOrEmpty(content.Country));
        }

        [Fact]
        public void GetDemoContent_WithName_ReturnsGivenName()
        {
            var provider = new DemoContentProvider("Company ABC");
            var content = provider.GetDemoContent();

            Assert.False(String.IsNullOrEmpty(content.Name));
            Assert.Equal("Company ABC", content.Company);
        }
    }
}
