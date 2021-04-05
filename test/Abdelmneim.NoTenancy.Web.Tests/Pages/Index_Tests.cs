using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Abdelmneim.NoTenancy.Pages
{
    public class Index_Tests : NoTenancyWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
