using Xunit;

namespace Angular.EntityFrameworkCore;

[CollectionDefinition(AngularTestConsts.CollectionDefinitionName)]
public class AngularEntityFrameworkCoreCollection : ICollectionFixture<AngularEntityFrameworkCoreFixture>
{

}
