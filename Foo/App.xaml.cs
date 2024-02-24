﻿using System.Windows;

// WPF Apps need two STA threads, one for event processing and one for rendering.
// a Single STA Thread is not sufficient.
using MainScheduler = Jcd.Tasks.SchedulerBoundTaskRunner<Jcd.Tasks.QuadStaThreadTaskScheduler>;

namespace Foo;

/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App //: Application
{
   [STAThread]
   public static int Main(string[] args)
   {
      return MainScheduler.Run(() => AsyncMain()).Result;
   }

   [STAThread]
   private static Task<int> AsyncMain()
   {
      var mainWindow = new MainWindow();
      var app        = new App();
      
      app.Run(mainWindow);
      return Task.FromResult(0);
   }
}