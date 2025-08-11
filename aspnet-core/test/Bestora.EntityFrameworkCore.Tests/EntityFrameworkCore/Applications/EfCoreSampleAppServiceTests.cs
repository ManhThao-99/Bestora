using Bestora.Samples;
using Xunit;

namespace Bestora.EntityFrameworkCore.Applications;

[Collection(BestoraTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<BestoraEntityFrameworkCoreTestModule>
{

}
