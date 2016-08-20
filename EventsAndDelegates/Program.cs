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
            var video1 = new Video() { Name = "Video 1" };
            var video2 = new Video() { Name = "Video 2" };

            var videoEncoder = new VideoEncoder();
            var libBuilder = new LibBuilder();            

            if (libBuilder.Plugins.Any())
            {
                libBuilder.BindPluginsToEvent(ref videoEncoder);

                videoEncoder.Encode(video1);
                videoEncoder.Encode(video2);
            }
        }
    }
}
