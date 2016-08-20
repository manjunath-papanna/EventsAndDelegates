//-----------------------------------------------------------------------
// <copyright file="Config.cs" company="Home">
//     Copyright (c) Home. All rights reserved.
// </copyright>
// <author>Manjunath Papanna</author>
//-----------------------------------------------------------------------
        
namespace EventsAndDelegates
{
    using System.Configuration;

    /// <summary>
    /// Class to read configuration details
    /// </summary>
    public static class Config
    {
        /// <summary>
        /// Gets LibFolder appSettings
        /// </summary>
        public static string LibFolder
        {
            get
            {
                return ConfigurationManager.AppSettings["LibFolder"].ToString();
            }
        }
    }
}
