using Tiered.Samples;
using Xunit;

namespace Tiered.EntityFrameworkCore.Domains;

[Collection(TieredTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<TieredEntityFrameworkCoreTestModule>
{

}
