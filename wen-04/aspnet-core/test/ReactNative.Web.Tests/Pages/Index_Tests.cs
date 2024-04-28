using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace ReactNative.Pages;

public class Index_Tests : ReactNativeWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
