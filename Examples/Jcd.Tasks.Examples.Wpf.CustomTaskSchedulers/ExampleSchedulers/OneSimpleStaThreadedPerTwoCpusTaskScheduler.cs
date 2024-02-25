using Jcd.Tasks.TaskSchedulers;

namespace Jcd.Examples.Wpf.CustomTaskSchedulers.ExampleSchedulers;

/// <summary>
/// A <see cref="TaskScheduler"/> that uses one STA thread for every two CPUs to execute
/// <see cref="Task"/> instances. At a minimum one thread is created. Inlining is not honored. See <see cref="SimpleThreadedTaskScheduler"/>
/// for details.
/// </summary>
public class OneSimpleStaThreadedPerTwoCpusTaskScheduler : SimpleStaThreadedTaskScheduler
{
   /// <inheritdoc />
   public OneSimpleStaThreadedPerTwoCpusTaskScheduler() : base(Environment.ProcessorCount / 2 == 0
                                                          ? 1
                                                          : Environment.ProcessorCount / 2
                                                      )
   {
   }
}