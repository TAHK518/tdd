﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using TagsCloudVisualization;

namespace DrawTagsCloud
{
	class Program
	{
		static void Main(string[] args)
		{
            var cloud = new CircularCloudLayouter(new Point(800, 600));
            var rand = new Random();
            for (var i = 0; i < 1000; i++)
            {
                var size = new Size(rand.Next(20, 150), rand.Next(20, 150));
                cloud.PutNextRectangle(size);
            }
            var image = CloudPainter.GetImageOfCloud(cloud, 100);
            var nameImage = "test.jpg";
            image.Save($"..\\..\\..\\{nameImage}");
        }
	}
}
