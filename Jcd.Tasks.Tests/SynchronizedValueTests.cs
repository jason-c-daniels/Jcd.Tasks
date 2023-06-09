﻿// ReSharper disable HeapView.DelegateAllocation

namespace Jcd.Tasks.Tests;

public class SynchronizedValueTests
{
    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public void Constructor_Creates_With_The_Provided_Value(int expectedValue)
    {
        using var sv = new SynchronizedValue<int>(expectedValue);
        Assert.Equal(expectedValue, sv.Value);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public void SetValue_Sets_And_Returns_The_Provided_Value(int expectedValue)
    {
        using var sv = new SynchronizedValue<int>();
        var result = sv.SetValue(expectedValue);
        Assert.Equal(expectedValue, sv.Value);
        Assert.Equal(expectedValue, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public async Task SetValueAsync_Sets_And_Returns_The_Provided_Value(int expectedValue)
    {
        using var sv = new SynchronizedValue<int>();
        var result = await sv.SetValueAsync(expectedValue);
        Assert.Equal(expectedValue, sv.Value);
        Assert.Equal(expectedValue, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public void GetValue_Sets_And_Returns_The_Provided_Value(int expectedValue)
    {
        using var sv = new SynchronizedValue<int>();
        sv.SetValue(expectedValue);
        Assert.Equal(expectedValue, sv.GetValue());
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public async Task GetValueAsync_Sets_And_Returns_The_Provided_Value(int expectedValue)
    {
        using var sv = new SynchronizedValue<int>();
        await sv.SetValueAsync(expectedValue);
        Assert.Equal(expectedValue, await sv.GetValueAsync());
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public void ChangeValue_Modifies_And_Returns_The_Modified_Value(int value)
    {
        int TimesTen(int i) => i * 10;
        var expectedValue = TimesTen(value);
        using var sv = new SynchronizedValue<int>();
        sv.SetValue(value);
        var result = sv.ChangeValue(TimesTen);
        Assert.Equal(expectedValue, sv.Value);
        Assert.Equal(expectedValue, result);
    }

    [Theory]
    [InlineData(1)]
    [InlineData(-1)]
    [InlineData(2)]
    public async Task ChangeValueAsync_Sets_And_Returns_The_Provided_Value(int value)
    {
        int TimesTen(int i) => i * 10;
        var expectedValue = TimesTen(value);
        using var sv = new SynchronizedValue<int>();
        await sv.SetValueAsync(value);
        var result = await sv.ChangeValueAsync(TimesTen);
        Assert.Equal(expectedValue, sv.Value);
        Assert.Equal(expectedValue, result);
    }
}