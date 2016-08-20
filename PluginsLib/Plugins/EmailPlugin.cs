//-----------------------------------------------------------------------
// <copyright file="EmailPlugin.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------
        
namespace PluginsLib.Plugins
{
    using System;
    using PluginsShared.Interfaces;
    using PluginsShared.PluginEventArgs;

    /// <summary>
    /// Email Plugin class
    /// </summary>
    public class EmailPlugin : IPlugin
    {
        /// <summary>
        /// Handler for VideoEncoded event
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="args">VideoEventArgs object</param>
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("EmailPlugin: sending an email... {0}", args.Video.Name);
        }
    }
}
