using Microsoft.AspNetCore.Builder;
using ReactNative;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<ReactNativeWebTestModule>();

public partial class Program
{
}
