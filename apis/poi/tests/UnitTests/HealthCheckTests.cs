using System;
using Xunit;
using poi.Models;

namespace UnitTests
{
    public class HealthCheckUnitTests
    {
        [Fact]
        public void HealthCheckTestModel()
        {
            Assert.Equal("POI Service Healthcheck 1", new Healthcheck().Message);
            Assert.Equal("Healthy 1", new Healthcheck().Status);

        }
    }
}
