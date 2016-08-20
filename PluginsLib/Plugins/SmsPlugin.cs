//-----------------------------------------------------------------------
// <copyright file="SmsPlugin.cs" company="Home">
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
    /// Plugin class
    /// </summary>
    public class SmsPlugin : IPlugin
    {
        /// <summary>
        /// Handler for VideoEncoded event
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="args">VideoEventArgs object</param>
        public void OnVideoEncoded(object sender, VideoEventArgs args)
        {
            Console.WriteLine("SmsPlugin: sending an sms... {0}", args.Video.Name);
        }
    }
}
