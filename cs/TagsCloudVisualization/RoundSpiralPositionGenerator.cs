﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace TagsCloudVisualization
{
    class RoundSpiralPositionGenerator
    {
        private Point center;
        private double angle = 0;
        public readonly double DeltaRadiusBetweenTurns = Math.PI;
        public readonly double DeltaAngle = 0.5;

        public RoundSpiralPositionGenerator(Point center)
        {
            this.center = center;
        }

        public Point Next()
        {
            angle += DeltaAngle;
            var dist = DeltaRadiusBetweenTurns * angle / 2 / Math.PI;
            var X = (int)(center.X + (dist * Math.Cos(angle)));
            var Y = (int)(center.Y + (dist * Math.Sin(angle)));
            return new Point(X, Y);
        }
    }
}
