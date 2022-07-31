// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace LearningBlazor.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using LearningBlazor.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using LearningBlazor.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\Pages\Weather.razor"
using LearningBlazor.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/weather")]
    public partial class Weather : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 24 "C:\Users\Brabim Manandhar\source\repos\LearningBlazor\LearningBlazor\Client\Pages\Weather.razor"
       
	WeatherForecast[] forecasts;

	void OnForecastSelected(DayOfWeek dayOfWeek)
	{
		foreach(var forecast in forecasts)
		{
			forecast.Selected = forecast.Date.DayOfWeek == dayOfWeek;
		}
	}

	protected override void OnInitialized()
	{
		forecasts = GenerateDemoForecats();
	}

	private WeatherForecast[] GenerateDemoForecats()
	{
		var rng = new Random();

		return Enumerable.Range(1, 5).Select(index => new WeatherForecast
		{
			Date = DateTime.Now.AddDays(index),
			TemperatureC = rng.Next(10, 25),
			Summary = Summaries[rng.Next(Summaries.Length)]
		}).ToArray();


	}

	private static string[] Summaries => new[] { "Sunny", "Cloudy", "Rainy" };

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
