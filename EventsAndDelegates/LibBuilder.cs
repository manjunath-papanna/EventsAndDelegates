//-----------------------------------------------------------------------
// <copyright file="LibBuilder.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------

namespace EventsAndDelegates
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using PluginsShared.Interfaces;

    /// <summary>
    /// Library builder class
    /// </summary>
    public class LibBuilder
    {
        /// <summary>
        /// Readonly property to store list of plugins
        /// </summary>
        public readonly List<IPlugin> Plugins;

        /// <summary>
        /// Initializes a new instance of the <see cref="LibBuilder" /> class
        /// </summary>
        public LibBuilder()
        {
            this.Plugins = new List<IPlugin>();

            if (Directory.Exists(Config.LibFolder))
            {
                string[] plugins = Directory.GetFiles(Config.LibFolder, "*.dll", SearchOption.AllDirectories);

                foreach (var plugin in plugins)
                {
                    Assembly assembly = Assembly.LoadFile(plugin);

                    Type[] types = assembly.GetExportedTypes();

                    foreach (Type type in types)
                    {
                        IPlugin instance = (IPlugin)Activator.CreateInstance(type);
                        this.Plugins.Add(instance);
                    }
                }
            }

            if (!this.Plugins.Any())
            {
                Console.WriteLine("No plugins loaded");
                Console.WriteLine("1 : Rebuild entire solution");
                Console.WriteLine("2 : Check whether plugin dll is available in path: {0}", Config.LibFolder);
            }
        }

        /// <summary>
        /// Binds the event handlers to events
        /// </summary>
        /// <param name="videoEncoder">object of VideoEncoder</param>
        public void BindPluginsToEvent(ref VideoEncoder videoEncoder)
        {
            foreach (IPlugin plugin in this.Plugins)
            {
                videoEncoder.VideoEncoded += plugin.OnVideoEncoded;
            }
        }
    }
}
