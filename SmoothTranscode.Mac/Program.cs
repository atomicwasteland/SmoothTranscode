using System;
using AppKit;
using Xamarin.Forms;

namespace SmoothTranscode.Mac
{
    /// <summary>
    /// Responsible for starting up the application.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// The entry point for the application.
        /// </summary>
        /// <param name="args">The command line arguments the application is launched with.</param>
        public static void Main(string[] args)
        {
            NSApplication.Init();
            Forms.Init();
            NSApplication.SharedApplication.Delegate = new AppDelegate();
            NSApplication.Main(args);
        }
    }
}
