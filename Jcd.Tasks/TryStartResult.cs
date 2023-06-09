﻿namespace Jcd.Tasks;

/// <summary>
/// The possible results of calling <see cref="TaskExtensions.TryStart"/>
/// </summary>
public enum TryStartResult
{
    /// <summary>
    /// Start was called and no exception resulted.
    /// </summary>
    SuccessfullyStarted,

    /// <summary>
    /// The task was already in a started state. Start was not called.
    /// </summary>
    AlreadyStarted,

    /// <summary>
    /// An exception occurred during the call to start. 
    /// </summary>
    ErrorDuringStart
}