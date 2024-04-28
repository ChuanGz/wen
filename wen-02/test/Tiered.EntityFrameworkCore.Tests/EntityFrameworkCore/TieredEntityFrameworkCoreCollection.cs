using Xunit;

namespace Tiered.EntityFrameworkCore;

[CollectionDefinition(TieredTestConsts.CollectionDefinitionName)]
public class TieredEntityFrameworkCoreCollection : ICollectionFixture<TieredEntityFrameworkCoreFixture>
{

}
