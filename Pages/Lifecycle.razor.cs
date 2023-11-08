using Microsoft.AspNetCore.Components;

namespace BlazorLifeCycle.Pages;

public partial class Lifecycle
{
    public override Task SetParametersAsync(ParameterView parameters)
    {
        Console.WriteLine("{0}()", nameof(SetParametersAsync));

        return base.SetParametersAsync(parameters);
    }

    protected override void OnInitialized()
    {
        Console.WriteLine("{0}()", nameof(OnInitialized));

        base.OnInitialized();
    }

    protected override Task OnInitializedAsync()
    {
        Console.WriteLine("{0}()", nameof(OnInitializedAsync));

        return base.OnInitializedAsync();
    }

    protected override void OnParametersSet()
    {
        Console.WriteLine("{0}()", nameof(OnParametersSet));

        base.OnParametersSet();
    }

    protected override Task OnParametersSetAsync()
    {
        Console.WriteLine("{0}()", nameof(OnParametersSetAsync));

        return base.OnParametersSetAsync();
    }

    protected override void OnAfterRender(bool firstRender)
    {
        Console.WriteLine("{0}({1}: {2})",
            nameof(OnAfterRender),
            nameof(firstRender),
            firstRender.ToString().ToLower());

        base.OnAfterRender(firstRender);
    }

    protected override Task OnAfterRenderAsync(bool firstRender)
    {
        Console.WriteLine("{0}({1}: {2})",
            nameof(OnAfterRenderAsync),
            nameof(firstRender),
            firstRender.ToString().ToLower());

        return base.OnAfterRenderAsync(firstRender);
    }
}
