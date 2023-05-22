#pragma checksum "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a20547a73c785f7fe6451827747fd94f5e4acef2"
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
#line 2 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
using Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/HallOfFame")]
    public partial class HallOfFame : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3 class=\"title\">Hall of Fame</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "movie-list");
#nullable restore
#line 7 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
     if (_movies.Count == 0)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<h4 class=\"title\">Loading...</h4>");
#nullable restore
#line 10 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
    }
    else
    {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
     foreach (var movie in _movies)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
         if(movie!=null)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "movie-card");
            __builder.OpenElement(6, "h4");
            __builder.AddAttribute(7, "class", "title");
            __builder.AddContent(8, 
#nullable restore
#line 18 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                   movie.ReleaseDate.Substring(0,4)

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n                ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "movie-poster-container");
#nullable restore
#line 20 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                     if (!string.IsNullOrEmpty(movie.PosterPath))
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "img");
            __builder.AddAttribute(13, "class", "movie-poster");
            __builder.AddAttribute(14, "src", "https://image.tmdb.org/t/p/w500/" + (
#nullable restore
#line 22 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                                                                        movie.PosterPath

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "alt", 
#nullable restore
#line 22 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                                                                                                movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
#nullable restore
#line 23 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(16, "<img class=\"fallback-poster\" src=\"fallback-image.jpg\" alt=\"No Poster Available\">");
#nullable restore
#line 27 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "movie-details");
            __builder.OpenElement(20, "h4");
            __builder.AddAttribute(21, "class", "movie-title");
            __builder.AddContent(22, 
#nullable restore
#line 30 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                              movie.Title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                    ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "movie-info");
            __builder.OpenElement(26, "p");
            __builder.AddAttribute(27, "class", "movie-release-date");
            __builder.AddMarkupContent(28, "<strong><em>Release Date:</em></strong> ");
            __builder.OpenElement(29, "em");
            __builder.AddContent(30, 
#nullable restore
#line 32 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                                                                                   movie.ReleaseDate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n                        ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "movie-vote-average");
            __builder.AddMarkupContent(34, "<strong><em>Vote Average:</em></strong> ");
            __builder.OpenElement(35, "em");
            __builder.AddContent(36, 
#nullable restore
#line 33 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                                                                                   movie.VoteAverage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.OpenElement(38, "p");
            __builder.AddAttribute(39, "class", "movie-vote-count");
            __builder.AddMarkupContent(40, "<strong><em>Vote Count:</em></strong> ");
            __builder.OpenElement(41, "em");
            __builder.AddContent(42, 
#nullable restore
#line 34 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
                                                                                               movie.VoteCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
         
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
     
        
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n\r\n");
            __builder.AddMarkupContent(44, "<style>\r\n\r\n    body{\r\n        background-color: #711324;\r\n        padding: 30px;\r\n    }\r\n    .title{\r\n        text-align: center;\r\n        color: black;\r\n        font-family: \"Berlin Sans FB\",serif;\r\n    }\r\n    .movie-list {\r\n        display: flex;\r\n        flex-wrap: wrap;\r\n        justify-content: center;\r\n    }\r\n\r\n    .movie-card {\r\n        width: 300px;\r\n        margin: 20px;\r\n        padding: 10px;\r\n        background-color: #f5f5f5;\r\n        border-radius: 5px;\r\n        box-shadow: 0 2px 4px rgba(0, 0, 0, 0.1);\r\n    }\r\n\r\n    .movie-poster-container {\r\n        height: 400px;\r\n        display: flex;\r\n        justify-content: center;\r\n        align-items: center;\r\n    }\r\n\r\n    .movie-poster, .fallback-poster {\r\n        max-width: 100%;\r\n        max-height: 100%;\r\n    }\r\n\r\n    .fallback-poster {\r\n        object-fit: contain;\r\n        background-color: #ddd;\r\n        padding: 10px;\r\n    }\r\n\r\n    .movie-details {\r\n        padding: 10px;\r\n        height: 100%;\r\n        display: flex;\r\n        flex-direction: column;\r\n        justify-content: space-between;\r\n    }\r\n\r\n    .movie-title {\r\n        font-size: 18px;\r\n        font-weight: bold;\r\n        margin-bottom: 10px;\r\n        word-break: break-word;\r\n        text-align: center;\r\n    }\r\n\r\n    .movie-info {\r\n        flex-grow: 1;\r\n    }\r\n\r\n    .movie-release-date,\r\n    .movie-vote-average,\r\n    .movie-vote-count {\r\n        margin-bottom: 5px;\r\n    }\r\n\r\n    .pagination {\r\n        display: flex;\r\n        justify-content: center;\r\n        margin-top: 20px;\r\n    }\r\n\r\n    .page-navigation {\r\n        padding: 10px 20px;\r\n        margin: 0 5px;\r\n        background-color: #007bff;\r\n        color: #fff;\r\n        border: none;\r\n        border-radius: 3px;\r\n        cursor: pointer;\r\n    }\r\n\r\n    .current-page {\r\n        font-weight: bold;\r\n    }\r\n\r\n    .search-bar {\r\n        display: flex;\r\n        align-items: center;\r\n        justify-content: center;\r\n        margin-bottom: 20px;\r\n    }\r\n\r\n    .search-bar input {\r\n        padding: 5px;\r\n        font-size: 14px;\r\n        border: 1px solid #ccc;\r\n        border-radius: 3px;\r\n    }\r\n\r\n    .search-bar button {\r\n        padding: 5px 10px;\r\n        background-color: #007bff;\r\n        color: #fff;\r\n        border: none;\r\n        border-radius: 3px;\r\n        cursor: pointer;\r\n        margin-left: 10px;\r\n    }\r\n\r\n    .close-button {\r\n        padding: 5px;\r\n        background-color: #dc3545;\r\n        color: #fff;\r\n        border: none;\r\n        border-radius: 50%;\r\n        cursor: pointer;\r\n        margin-left: 10px;\r\n    }\r\n\r\n    .close-button span {\r\n        font-size: 12px;\r\n        line-height: 1;\r\n    }\r\n    \r\n    .filter-bar {\r\n            display: flex;\r\n            align-items: center;\r\n            justify-content: center;\r\n            margin-bottom: 20px;\r\n        }\r\n    \r\n        .filter-bar label {\r\n            margin-right: 10px;\r\n            background-color: #f5f5f5;\r\n            border-radius: 3px;\r\n            border: white 1px solid;\r\n            padding: 4px;\r\n        }\r\n    \r\n        .filter-bar select {\r\n            padding: 5px;\r\n            font-size: 14px;\r\n            border: 1px solid #ccc;\r\n            border-radius: 3px;\r\n        }\r\n</style>");
        }
        #pragma warning restore 1998
#nullable restore
#line 196 "D:\SEM6\SEP6\Project\SEP6\SEP6\Pages\HallOfFame.razor"
       
    private List<MovieDetails> _movies = new List<MovieDetails>();
    TMDBApiClient _tmdbApiClient;
    
    
    protected override async Task OnInitializedAsync()
    {
        _tmdbApiClient = new TMDBApiClient("7f4f7ef07e4add825a6a5cedbbf03857");
        await LoadMovies();
    }
    
    private async Task LoadMovies()
    {
        
        _movies = await _tmdbApiClient.GetHoFMovie();
    }
    

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
