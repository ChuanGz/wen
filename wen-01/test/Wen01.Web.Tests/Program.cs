using Microsoft.AspNetCore.Builder;
using Wen01;
using Volo.Abp.AspNetCore.TestBase;

var builder = WebApplication.CreateBuilder();
await builder.RunAbpModuleAsync<Wen01WebTestModule>();

public partial class Program
{
}
