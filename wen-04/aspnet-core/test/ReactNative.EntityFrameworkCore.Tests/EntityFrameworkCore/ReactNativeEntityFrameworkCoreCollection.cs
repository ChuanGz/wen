using Xunit;

namespace ReactNative.EntityFrameworkCore;

[CollectionDefinition(ReactNativeTestConsts.CollectionDefinitionName)]
public class ReactNativeEntityFrameworkCoreCollection : ICollectionFixture<ReactNativeEntityFrameworkCoreFixture>
{

}
