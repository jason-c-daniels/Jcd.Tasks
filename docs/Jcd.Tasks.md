## Jcd.Tasks Namespace

Provides types and extension methods to assist with the creation, execution, and  
management of unstarted [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') instances.

| Classes | |
| :--- | :--- |
| [BlockingTaskProcessor](Jcd.Tasks.BlockingTaskProcessor.md 'Jcd.Tasks.BlockingTaskProcessor') | Represents a high level object that enqueues and executes actions, functions, and unstarted tasks,<br/>waiting for each to complete before executing the next. |
| [SynchronizedValue&lt;T&gt;](Jcd.Tasks.SynchronizedValue_T_.md 'Jcd.Tasks.SynchronizedValue<T>') | Provides a simple async-safe method of setting, getting, and altering values intended<br/>to be shared among tasks and threads. |
| [TaskExtensions](Jcd.Tasks.TaskExtensions.md 'Jcd.Tasks.TaskExtensions') | A set of helpers for [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task') objects. |
| [UnstartedTask](Jcd.Tasks.UnstartedTask.md 'Jcd.Tasks.UnstartedTask') | A Task factory that wraps the constructor with a tiny bit of logic, simplifying the process<br/>of directly creating unstarted [System.Threading.Tasks.Task](https://docs.microsoft.com/en-us/dotnet/api/System.Threading.Tasks.Task 'System.Threading.Tasks.Task')s. |

| Enums | |
| :--- | :--- |
| [TryStartResult](Jcd.Tasks.TryStartResult.md 'Jcd.Tasks.TryStartResult') | The possible results of calling [TryStart(this Task, Exception, TaskScheduler)](Jcd.Tasks.TaskExtensions.TryStart(thisSystem.Threading.Tasks.Task,System.Exception,System.Threading.Tasks.TaskScheduler).md 'Jcd.Tasks.TaskExtensions.TryStart(this System.Threading.Tasks.Task, System.Exception, System.Threading.Tasks.TaskScheduler)') |
