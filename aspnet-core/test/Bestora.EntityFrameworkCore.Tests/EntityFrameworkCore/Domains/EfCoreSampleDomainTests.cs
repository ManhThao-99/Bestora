using Bestora.Samples;
using Xunit;

namespace Bestora.EntityFrameworkCore.Domains;

[Collection(BestoraTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<BestoraEntityFrameworkCoreTestModule>
{

}
