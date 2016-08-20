//-----------------------------------------------------------------------
// <copyright file="IPlugin.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------
        
namespace PluginsShared.Interfaces
{
    using PluginsShared.PluginEventArgs;

    /// <summary>
    /// IPlugin interface
    /// </summary>
    public interface IPlugin
    {
        /// <summary>
        /// Handler for VideoEncoded event
        /// </summary>
        /// <param name="sender">Sending object</param>
        /// <param name="args">VideoEventArgs object</param>
        void OnVideoEncoded(object sender, VideoEventArgs args);
    }
}
