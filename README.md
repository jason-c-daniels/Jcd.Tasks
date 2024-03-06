# Jcd.Tasks

## [DEPRECATED]

See [Jcd.Threading](https://github.com/jason-c-daniels/Jcd.Threading) for the latest code.

A *netstandard2.0* library that provides utility classes to help with managing `Task`s,
creating custom `TaskScheduler`s, and creating thread safe value access.

Read the API docs carefully.

## Types Provided.

* The main types provided are:
   * `TaskSchedulerExtensions` - a static class supporting a `Task.Run`-compatible API that ensures
     actions are executed on a specified instance of `TaskScheduler`.
   * `SynchronizedValue` - a flexible and CLS compliant re-imagining of `Interlocked`.
   * `CurrentSchedulerTaskRunner` - a static class supporting a `Task.Run`-compatible API that ensures
     actions are executed on the current executing `TaskScheduler`.
   * `CuustomSchedulerTaskRunner` - a static class supporting a `Task.Run`-compatible API that ensures
     actions are executed on a single instance of a custom implementation of `TaskScheduler`.
   * `SimpleThreadedTaskScheduler` - A custom task scheduler base class that allocates a fixed pool
     of threads on which to run tasks.

## Examples

See [EXAMPLES.md](./EXAMPLES.md) for detailed examples.

## Badges

[![GitHub](https://img.shields.io/github/license/jason-c-daniels/Jcd.Tasks)](https://github.com/jason-c-daniels/Jcd.Tasks/blob/main/LICENSE)
[![Build status](https://ci.appveyor.com/api/projects/status/sbmfvmr1jmcf1pic?svg=true)](https://ci.appveyor.com/project/jason-c-daniels/jcd-tasks)
[![CodeFactor Grade](https://img.shields.io/codefactor/grade/github/jason-c-daniels/Jcd.Tasks)](https://www.codefactor.io/repository/github/jason-c-daniels/Jcd.Tasks)
[![Quality Gate Status](https://sonarcloud.io/api/project_badges/measure?project=jason-c-daniels_Jcd.Tasks&metric=alert_status)](https://sonarcloud.io/summary/new_code?id=jason-c-daniels_Jcd.Tasks)

[![MyGet](https://img.shields.io/myget/jason-c-daniels/v/Jcd.Tasks?logo=nuget)](https://www.myget.org/feed/jason-c-daniels/package/nuget/Jcd.Tasks)
[![Nuget](https://img.shields.io/nuget/v/Jcd.Tasks?logo=nuget)](https://www.nuget.org/packages/Jcd.Tasks)

[![API Docs](https://img.shields.io/badge/Read-The%20API%20Documentation-blue?style=for-the-badge)](https://github.com/jason-c-daniels/Jcd.Tasks/blob/main/docs/Jcd.Tasks.md)