using Tiered.Samples;
using Xunit;

namespace Tiered.EntityFrameworkCore.Applications;

[Collection(TieredTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<TieredEntityFrameworkCoreTestModule>
{

}
