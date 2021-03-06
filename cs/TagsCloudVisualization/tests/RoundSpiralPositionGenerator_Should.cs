﻿using System.Drawing;
using FluentAssertions;
using NUnit.Framework;

namespace TagsCloudVisualization
{
    [TestFixture]
    public class RoundSpiralPositionGenerator_Should
    {
        [Test]
        public void FirstStep_Should_EqualCenterSpiral()
        {
            var center = new Point(800, 600);
            var spiralGenerator = new RoundSpiralPositionGenerator(center);
            spiralGenerator.Next().Should().BeEquivalentTo(center);
        }

        [Test]
        public void AfterManyStep_Should_DeltaBetweenCenterAndCurrentStepMoreThanRadiusBetweenTurns()
        {
            var center = new Point(800, 600);
            var spiralGenerator = new RoundSpiralPositionGenerator(center);
            for (var i = 0; i < 100; i++)
            {
                spiralGenerator.Next();
            }
            var currentPoint = spiralGenerator.Next();
            currentPoint.GetDistance(center).Should().BeGreaterThan((int)spiralGenerator.DeltaRadiusBetweenTurns);
        }
    }
}
