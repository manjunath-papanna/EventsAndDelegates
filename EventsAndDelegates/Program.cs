//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------

namespace EventsAndDelegates
{
    using System;
    using System.Configuration;
    using System.Linq;
    using PluginsShared.Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Program class
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Entry point
        /// </summary>
        /// <param name="args">array of string</param>
        private static void Main(string[] args)
        {
            var videos = new List<Video>()
            {
                new Video { Name = "Video 1" },
                new Video { Name = "Video 2" },
                new Video { Name = "Video 3" }
            };

            var videoEncoder = new VideoEncoder();
            var libBuilder = new LibBuilder();

            if (libBuilder.Plugins.Any())
            {
                libBuilder.BindPluginsToEvent(ref videoEncoder);

                foreach (var video in videos)
                {
                    videoEncoder.Encode(video);
                }
            }
        }
    }
}
