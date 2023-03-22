using System.Threading.Tasks;
using Xunit;

namespace Najd.Md.Items.Samples;

public class SampleManager_Tests : ItemsDomainTestBase
{
    //private readonly SampleManager _sampleManager;

    public SampleManager_Tests()
    {
        //_sampleManager = GetRequiredService<SampleManager>();
    }

    [Fact]
    public Task Method1Async()
    {
        return Task.CompletedTask;
    }
}
