using System;
using Faker;


namespace MicrosoftFieldDemos.Artifacts
{
    public class DemoContentProvider
    {
        private string _CompanyName;

        public DemoContentProvider(string companyName = null) {
            _CompanyName = companyName;
        }

        public DemoContent GetDemoContent() {
            var content = new DemoContent {
                Name = Faker.Name.FullName(),
                Company = _CompanyName ?? Faker.Company.Name()
            };

            return content;
        }
    }
}
