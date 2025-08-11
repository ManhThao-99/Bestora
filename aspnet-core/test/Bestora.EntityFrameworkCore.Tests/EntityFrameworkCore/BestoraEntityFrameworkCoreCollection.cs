using Xunit;

namespace Bestora.EntityFrameworkCore;

[CollectionDefinition(BestoraTestConsts.CollectionDefinitionName)]
public class BestoraEntityFrameworkCoreCollection : ICollectionFixture<BestoraEntityFrameworkCoreFixture>
{

}
