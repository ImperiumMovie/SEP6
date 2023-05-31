// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\source\repos\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\HallOfFame.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\HallOfFame.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\HallOfFame.razor"
using Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/HallOfFame")]
    public partial class HallOfFame : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 189 "C:\Users\nicol\source\repos\SEP6\SEP6\Pages\HallOfFame.razor"
       
    private List<MovieDetails> _movies = new List<MovieDetails>();

    protected override async Task OnInitializedAsync()
    {
        if (DataSession.User == null)
            NavigationManager.NavigateTo("LogIn");
        await LoadMovies();
    }

    private async Task LoadMovies()
    {
        _movies = await _tmdbApiClient.GetHoFMovie();
    }

    private void OpenMovieOverview(MovieDetails movie)
    {
        DataSession.MovieDetails = movie;
        DataSession.LastLink = "/HallOfFame";
        NavigationManager.NavigateTo("/MovieOverview");
    }
    
    private void NavigateBack()
    {
        NavigationManager.NavigateTo("/MovieList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IApiRetriever _tmdbApiClient { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
