﻿// ReSharper disable HeapView.DelegateAllocation
// ReSharper disable HeapView.ClosureAllocation
// ReSharper disable HeapView.ObjectAllocation
// ReSharper disable UnusedMethodReturnValue.Global
// ReSharper disable HeapView.ObjectAllocation.Evident

namespace Jcd.Tasks.Examples;

/// <summary>
/// Demonstrates some of the uses for <see cref="SynchronizedValue{T}"/>
/// </summary>
public static class SynchronizedValueExample
{
   /// <summary>
   /// Runs the example code. Returns 0 if successful. Throws an exception otherwise.
   /// </summary>
   /// <returns>0</returns>
   /// <exception cref="TaskCanceledException"></exception>
   public static async Task<int> Run()
   {
      var       counter = new SynchronizedValue<int>();
      using var cts = new CancellationTokenSource(TimeSpan.FromMinutes(0.11)); // set a total run time of 0.11 minutes

      // create a hot-task that starts incrementing the value by 1 every 100 ms;
      var incrementTask = CreateIncrementTask(cts, counter);

      // create a hot-task that starts decrements the value by 3 every 420 ms;
      var decBy4Task = CreateDecrementBy4Task(cts, counter);

      // create a hot-task that sets the to 10 every 5 seconds;
      var setTo20Task = CreateSetTo20Task(cts, counter);

      // create a hot-task that reports the value and a timestamp every 100ms
      var reportValueTask = CreateReportValueTask(cts, counter);

      // wait for the tasks to finish regardless if their faulted or cancelled status.
      await Task.WhenAll(reportValueTask, setTo20Task, decBy4Task, incrementTask);

      // now report their statuses.
      Console.WriteLine($"reportValue.Status {reportValueTask.Status}");
      Console.WriteLine($"setTo20Task.Status {setTo20Task.Status}");
      Console.WriteLine($"decBy4Task.Status {decBy4Task.Status}");
      Console.WriteLine($"incrementTask.Status {incrementTask.Status}");

      return 0;
   }

   private static Task CreateReportValueTask(CancellationTokenSource cts, SynchronizedValue<int> counter)
   {
      var reportValue = Task.Run(async () =>
                                 {
                                    try
                                    {
                                       while (!cts.IsCancellationRequested)
                                       {
                                          await Task.Delay(100, cts.Token);
                                          Console.WriteLine($"{DateTime.Now:O} : counter.Value = {counter.Value}");
                                       }
                                    }
                                    catch (TaskCanceledException)
                                    {
                                       // ignored. This is expected behavior.
                                    }
                                 }
                               , cts.Token
                                );

      return reportValue;
   }

   private static Task CreateSetTo20Task(CancellationTokenSource cts, SynchronizedValue<int> counter)
   {
      var setTo20Task = Task.Run(async () =>
                                 {
                                    try
                                    {
                                       while (!cts.IsCancellationRequested)
                                       {
                                          await Task.Delay(5000, cts.Token);
                                          await counter.SetValueAsync(10);
                                          Console.WriteLine($"{DateTime.Now:O} : Reset to 10!");
                                          await Console.Out.FlushAsync();
                                       }
                                    }
                                    catch (TaskCanceledException)
                                    {
                                       // ignored. This is expected behavior.
                                    }
                                 }
                               , cts.Token
                                );

      return setTo20Task;
   }

   private static Task CreateDecrementBy4Task(CancellationTokenSource cts, SynchronizedValue<int> counter)
   {
      var decBy4Task = Task.Run(async () =>
                                {
                                   try
                                   {
                                      while (!cts.IsCancellationRequested)
                                      {
                                         await Task.Delay(420, cts.Token);
                                         await counter.ChangeValueAsync(x => Task.FromResult(x - 3));
                                      }
                                   }
                                   catch (TaskCanceledException)
                                   {
                                      // ignored. This is expected behavior.
                                   }
                                }
                              , cts.Token
                               );

      return decBy4Task;
   }

   private static Task CreateIncrementTask(CancellationTokenSource cts, SynchronizedValue<int> counter)
   {
      var incrementTask = Task.Run(async () =>
                                   {
                                      try
                                      {
                                         while (!cts.IsCancellationRequested)
                                         {
                                            await Task.Delay(100, cts.Token);
                                            await counter.ChangeValueAsync(x => Task.FromResult(x + 1));
                                         }
                                      }
                                      catch (TaskCanceledException)
                                      {
                                         // ignored. This is expected behavior.
                                      }
                                   }
                                 , cts.Token
                                  );

      return incrementTask;
   }
}