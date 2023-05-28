#pragma checksum "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9a4b08886e5be0663db3e34ca101d69680b185db"
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
#line 1 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using SEP6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using SEP6.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Authentication;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\SEM6\SEP6\Project\SEP6\SEP6\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
using SEP6.Temporary;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/MovieOverview")]
    public partial class MovieOverview : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 style=\"text-align: center; color: white\">Movie Overview</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "movie-card");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "poster-container");
#nullable restore
#line 12 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
         if (!string.IsNullOrEmpty(DataSession.MovieDetails.PosterPath))
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(5, "img");
            __builder.AddAttribute(6, "class", "poster");
            __builder.AddAttribute(7, "src", "https://image.tmdb.org/t/p/original/" + (
#nullable restore
#line 14 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                                                          DataSession.Instance.MovieDetails.PosterPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "alt", 
#nullable restore
#line 14 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                                                                                                              DataSession.Instance.MovieDetails.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 15 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(9, "<img class=\"fallback-poster\" src=\"fallback-image.jpg\" alt=\"No Poster Available\">");
#nullable restore
#line 19 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n    ");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "movie-details");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "info-container");
            __builder.OpenElement(15, "h4");
            __builder.AddAttribute(16, "class", "movie-title");
            __builder.AddContent(17, 
#nullable restore
#line 23 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                     DataSession.Instance.MovieDetails.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenElement(19, "p");
            __builder.AddMarkupContent(20, "<strong>Release Date:</strong> ");
            __builder.AddContent(21, 
#nullable restore
#line 24 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                               DataSession.Instance.MovieDetails.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "p");
            __builder.AddMarkupContent(24, "<strong>Vote Average:</strong> ");
            __builder.AddContent(25, 
#nullable restore
#line 25 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                               DataSession.Instance.MovieDetails.VoteAverage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "p");
            __builder.AddMarkupContent(28, "<strong>Vote Count:</strong> ");
            __builder.AddContent(29, 
#nullable restore
#line 26 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                             DataSession.Instance.MovieDetails.VoteCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.AddMarkupContent(31, "<p><strong>Overview:</strong></p>\r\n            ");
            __builder.OpenElement(32, "p");
            __builder.AddContent(33, 
#nullable restore
#line 28 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                DataSession.Instance.MovieDetails.Overview

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "back-button");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn-back");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 34 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
                                       NavigateBack

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Back");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n\r\n");
            __builder.AddMarkupContent(42, @"<style>
    html, body {
        height: 100%;
        margin: 0;
        padding: 0;
    }

    body {
        background-image: url('images/Background.jpg');
        background-size: cover;
        background-position: center;
        background-repeat: no-repeat;
        background-attachment: fixed;
        padding: 20px;
    }

    .movie-card {
        display: flex;
        flex-direction: column;
        align-items: center;
        max-width: 800px;
        margin: 0 auto;
        padding: 20px;
        background-color: transparent;
        border-radius: 10px;
        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);
    }

    .poster-container {
        width: 50%;
        margin-bottom: 20px;
    }

    .poster, .fallback-poster {
        max-width: 100%;
        max-height: 100%;
    }

    .movie-details {
        width: 100%;
        color: white;
    }

    .info-container {
        padding-top: 20px;
    }

    .movie-title {
        font-size: 24px;
        font-weight: bold;
        margin-bottom: 10px;
        color: white;
    }

    .back-button {
        position: absolute;
        top: 10px;
        right: 10px;
    }

    .btn-back {
        padding: 5px 10px;
        background-color: #ff6b6b;
        color: #fff;
        border: none;
        border-radius: 3px;
        margin: 25px;
        cursor: pointer;
    }
</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 108 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\MovieOverview.razor"
       
    private void NavigateBack()
    {
        NavigationManager.NavigateTo("/MovieList");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DataSession DataSession { get; set; }
    }
}
#pragma warning restore 1591
