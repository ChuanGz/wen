using Wen01.Samples;
using Xunit;

namespace Wen01.EntityFrameworkCore.Domains;

[Collection(Wen01TestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<Wen01EntityFrameworkCoreTestModule>
{

}
