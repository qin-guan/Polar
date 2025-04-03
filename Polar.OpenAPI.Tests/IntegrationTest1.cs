using System.Net.Http.Json;
using Polar.OpenAPI.Tests.Data;

namespace Polar.OpenAPI.Tests
{
    public class IntegrationTest1
    {
        [ClassDataSource<PolarCredentialsDataClass>]
        [Test]
        public async Task GetApiHealthReturnsOkStatus(PolarCredentialsDataClass polarCredentialsData)
        {
            // Arrange
            // Act
            // Assert
        }
    }
}