﻿using Domain;
using Xunit;
using NSubstitute;
using Microsoft.Extensions.Logging;

namespace Tests
{
    public class Tests
    {
        [Fact]
        public void Test1()
        {
            var service = new DomainService(Substitute.For<ILogger<DomainService>>());

            var result = service.Process(new Request());

            Assert.IsType<Response>(result);
        }
    }
}
