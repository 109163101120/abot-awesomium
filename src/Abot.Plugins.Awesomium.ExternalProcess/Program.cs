﻿using System;
using System.Windows.Forms;
using Abot.Plugins.Awesomium.ExternalProcess.Forms;

namespace Abot.Plugins.Awesomium.ExternalProcess
{
   static class Program
   {
      /// <summary>
      /// The main entry point for the application.
      /// </summary>
      [STAThread]
      static void Main(string[] args)
      {
         Globals.ChannelId = args[0];

         Application.EnableVisualStyles();
         Application.SetCompatibleTextRenderingDefault(false);
         Application.Run(new WebHostForm());
      }
   }
}
