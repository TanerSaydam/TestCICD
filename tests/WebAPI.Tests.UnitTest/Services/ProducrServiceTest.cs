using FluentAssertions;
using WebAPI.Services;

namespace WebAPI.Tests.UnitTest.Services;
public sealed class ProducrServiceTest
{
    [Fact]
    public void Test()
    {
        ProductService productService = new();

        var result = productService.Test();

        result.Should().BeFalse();
    }
}