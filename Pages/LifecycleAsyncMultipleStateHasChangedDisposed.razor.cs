﻿using Microsoft.AspNetCore.Components;

namespace BlazorLifeCycle.Pages;

public partial class LifecycleAsyncMultipleStateHasChangedDisposed : IDisposable, IAsyncDisposable
{
    List<string> _greeting = new List<string>();

    public override async Task SetParametersAsync(ParameterView parameters)
    {
        Console.WriteLine("SetParametersAsync - Begin");
        await base.SetParametersAsync(parameters);
        Console.WriteLine("SetParametersAsync - End");
    }

    protected override void OnInitialized() => Console.WriteLine("OnInitialized");

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("OnInitializedAsync - Begin");

        _greeting.Add("Welcome");

        await Task.Delay(1000);
        _greeting.Add("to");
        StateHasChanged();

        await Task.Delay(1000);
        _greeting.Add("Blazor in Action");

        Console.WriteLine("OnInitializedAsync - End");
    }

    protected override void OnParametersSet() => Console.WriteLine("OnParametersSet");

    protected override async Task OnParametersSetAsync() => Console.WriteLine("OnParametersSetAsync");

    protected override void OnAfterRender(bool firstRender) => Console.WriteLine($"OnAfterRender (First render: {firstRender})");

    protected override async Task OnAfterRenderAsync(bool firstRender) => Console.WriteLine($"OnAfterRenderAsync (First render: {firstRender})");

    public void Dispose()
    {
        Console.WriteLine("Dispose");
    }

    public async ValueTask DisposeAsync()
    {
        Console.WriteLine("DisposeAsync");
    }
}
