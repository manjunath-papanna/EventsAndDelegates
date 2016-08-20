//-----------------------------------------------------------------------
// <copyright file="VideoEventArgs.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------
        
namespace PluginsShared.PluginEventArgs
{
    using System;
    using PluginsShared.Entities;

    /// <summary>
    /// VideoEventArgs class
    /// </summary>
    public class VideoEventArgs : EventArgs
    {
        /// <summary>
        /// Gets or sets Video object
        /// </summary>
        public Video Video { get; set; }
    }
}
