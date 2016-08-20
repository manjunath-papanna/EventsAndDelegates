//-----------------------------------------------------------------------
// <copyright file="VideoEncoder.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------
        
namespace EventsAndDelegates
{
    using System;
    using System.Threading;
    using PluginsShared.Entities;
    using PluginsShared.PluginEventArgs;

    /// <summary>
    /// Video encoder class
    /// </summary>
    public class VideoEncoder
    {
        /// <summary>
        /// Gets or sets Event handler
        /// </summary>
        public EventHandler<VideoEventArgs> VideoEncoded { get; set; }

        /// <summary>
        /// Method to encode video
        /// </summary>
        /// <param name="video">Video object</param>
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...{0}", video.Name);
            Thread.Sleep(3000);

            this.OnVideoEncoded(video);
        }

        /// <summary>
        /// Method implementing VideoEncoded event handler
        /// </summary>
        /// <param name="video">Video object</param>
        protected virtual void OnVideoEncoded(Video video)
        {
            if (this.VideoEncoded != null)
            {
                var args = new VideoEventArgs
                {
                    Video = video
                };

                this.VideoEncoded(this, args);
            }
        }
    }
}
