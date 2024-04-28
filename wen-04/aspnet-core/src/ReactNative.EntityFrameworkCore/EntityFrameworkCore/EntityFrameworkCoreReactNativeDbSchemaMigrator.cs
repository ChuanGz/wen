using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ReactNative.Data;
using Volo.Abp.DependencyInjection;

namespace ReactNative.EntityFrameworkCore;

public class EntityFrameworkCoreReactNativeDbSchemaMigrator
    : IReactNativeDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreReactNativeDbSchemaMigrator(
        IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolve the ReactNativeDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<ReactNativeDbContext>()
            .Database
            .MigrateAsync();
    }
}
