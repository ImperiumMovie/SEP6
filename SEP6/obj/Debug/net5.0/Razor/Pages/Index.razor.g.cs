#pragma checksum "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8f5facbd2630d6cf683bbbef30ad6dc50333f05"
// <auto-generated/>
#pragma warning disable 1591
namespace SEP6.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\RiderProjects\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : global::Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align: center;\">Movie List</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "style", "display: flex; flex-direction: column; align-items: center;");
#nullable restore
#line 6 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor"
     foreach(var movie in _movies)
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "style", "display: flex; flex-direction: column; align-items: center; margin-bottom: 20px;");
            __builder.OpenElement(5, "p");
            __builder.AddAttribute(6, "style", "font-weight: bold; font-size: 18px;");
#nullable restore
#line 9 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor"
__builder.AddContent(7, movie.Title);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "img");
            __builder.AddAttribute(10, "src", "https://image.tmdb.org/t/p/w500/" + (
#nullable restore
#line 10 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor"
                                                       movie.Poster_Path

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "alt", 
#nullable restore
#line 10 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor"
                                                                                movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "style", "width: 200px; height: 300px; object-fit: cover;");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 12 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n\r\n");
            __builder.AddMarkupContent(14, "<style>\r\n    body {\r\n        background-color: #f2f2f2;\r\n    }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "C:\Users\nicol\RiderProjects\SEP6\SEP6\Pages\Index.razor"
       

    private List<TMDBApiClient.Movie> _movies=new();
    
    protected override async Task OnInitializedAsync()
    {
        //TMDBApiClient tmdbApiClient = new TMDBApiClient("7f4f7ef07e4add825a6a5cedbbf03857");
       // _movies = await tmdbApiClient.GetMovies();
        Navigation.NavigateTo("/login");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager Navigation { get; set; }
    }
}
#pragma warning restore 1591
