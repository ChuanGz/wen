using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace Wen01.Pages;

public class Index_Tests : Wen01WebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
