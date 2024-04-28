using Wen01.Samples;
using Xunit;

namespace Wen01.EntityFrameworkCore.Applications;

[Collection(Wen01TestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<Wen01EntityFrameworkCoreTestModule>
{

}
