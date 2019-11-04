﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using FluentAssertions;
using NUnit.Framework;

namespace TagsCloudVisualization
{

    [TestFixture]
    public class CircularCloudLayouter_Initialization_Should
    {
        [Test]
        public void ThrowException_WhenXIsNegativeNumberCenter()
        {
            Action act = () => new CircularCloudLayouter(new Point(-1, 20));
            act.Should().Throw<ArgumentException>();
        }

        [Test]
        public void ThrowException_WhenYIsNegativeNumberCenter()
        {
            Action act = () => new CircularCloudLayouter(new Point(20, -1));
            act.Should().Throw<ArgumentException>();
        }
    }
}