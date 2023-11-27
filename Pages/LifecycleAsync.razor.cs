using Microsoft.AspNetCore.Components;

namespace BlazorLifeCycle.Pages;

public partial class LifecycleAsync
{
    public override async Task SetParametersAsync(ParameterView parameters)
    {
        Console.WriteLine("LifecycleAsync");
        Console.WriteLine("------------------------------------------");
        Console.WriteLine("SetParametersAsync - Begin");
        await base.SetParametersAsync(parameters);
        Console.WriteLine("SetParametersAsync - End");
    }

    protected override void OnInitialized() => Console.WriteLine("OnInitialized");

    protected override async Task OnInitializedAsync()
    {
        Console.WriteLine("OnInitializedAsync - Begin");
        await Task.Delay(300);
        Console.WriteLine("OnInitializedAsync - End");
    }

    protected override void OnParametersSet() => Console.WriteLine("OnParametersSet");

    protected override async Task OnParametersSetAsync() => Console.WriteLine("OnParametersSetAsync");

    protected override void OnAfterRender(bool firstRender) => Console.WriteLine($"OnAfterRender (First render: {firstRender})");

    protected override async Task OnAfterRenderAsync(bool firstRender) => Console.WriteLine($"OnAfterRenderAsync (First render: {firstRender})");
}
