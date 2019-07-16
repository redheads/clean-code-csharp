using System;
using FluentAssertions;
using Xunit;

namespace SolidDemos._4_ISP.Bad
{
    public class VehicleTests
    {
        [Fact]
        public void Car_can_move_forward()
        {
            var sut = new Car();
            sut.Drive().Should().Be("moving forward fast");
        }

        [Fact]
        public void Car_can_start_engine()
        {
            var sut = new Car();
            sut.StartEngine().Should().Be("Brum, Brum");
        }

        [Fact]
        public void Bicycle_can_move_forward()
        {
            var sut = new Bicycle();
            sut.Drive().Should().Be("moving forward slowly");
        }

        [Fact]
        public void Bicycle_can_not_start_engine()
        {
            var sut = new Bicycle();
            Action action = () => sut.StartEngine();
            action.Should().Throw<NotImplementedException>();
        }
    }
}